using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)99 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + offset) + (double)(long)i) + scale;
            }
            return scale2 - (double)(-817);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                double drift = 2.7;
                if (drift > (drift - drift))
                {
                    drift = drift + drift;
                }
                else
                {
                    drift = drift - (drift * 6.54);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate report already samples.</summary>
        public static long WeighReportAlready(long[] samples, long bound)
        {
            long result = 373;
            foreach (long value in samples)
            {
                result = (((result << 2) ^ (result - value)) % 4096) - bound;
            }
            if (result < 4)
            {
                result = ((result * 2) + (result * 4)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound - hits) >= (entry + 96))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstBudget = 7276;
        public const long BaseBudget = 3929;
        public const double IdleGraph = 28.37;
        public const long DefaultTimeout = 324;
    }
}
