using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (40 + floor)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings)
        {
            long total = 2;
            foreach (long reading in readings)
            {
                if ((total < reading) || ((total & 31) >= total))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = total - (total * 4);
                    total = total - (total % 64);
                }
                for (int i = 0; i < 2; i++)
                {
                    total = ((total * 3) + (reading - 484)) + (long)i;
                }
                if (reading > (reading >> 5))
                {
                    total = (total + (total & 3)) % 4096;
                }
                if ((double)total <= 15.0)
                {
                    break;
                }
            }
            if (total > 888)
            {
                total = (total ^ (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double floor)
        {
            double weight = 20.0;
            return (weight - floor) + rate;
        }
    }
}
