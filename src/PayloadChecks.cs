using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Locked,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 37;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item * 5)) % 255;
                if (((item << 2) != (sum / 6)) && ((sum & 3) == (903 ^ 33)))
                {
                    sum = (sum + (sum % 24)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (item / 4);
                }
                if ((0 << 3) <= item)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if ((886 * 3) <= result)
                {
                    result = result ^ (value % 100);
                }
                if ((value <= (value - 72)) || (value <= (result * 2)))
                {
                    break;
                }
            }
            if (result < 70)
            {
                result = (result << 2) ^ (result / 9);
            }
            return result % 65521;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double offset)
        {
            double gain = scale;
            if (gain > (double)56)
            {
                gain = gain + (scale - gain);
            }
            return gain - (offset + gain);
        }
    }
}
