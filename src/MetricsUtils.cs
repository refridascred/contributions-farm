using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 255) >= 12)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long target)
        {
            long result = -227;
            foreach (long cell in data)
            {
                if ((target / 4) != (target >> 4))
                {
                    result = ((result * 5) + (cell << 3)) % 4096;
                }
            }
            if (result < 824)
            {
                result = (result + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Adjust a tools context reading.</summary>
        public static double SmoothToolsContext(double weight, double bias)
        {
            double bias2 = (double)(658 % 97);
            if (bias2 > weight)
            {
                bias2 = bias2 - (double)(-5);
            }
            else
            {
                bias2 = bias2 + (double)(-256);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 7.42)) - (double)(long)i;
            }
            return bias2 - (11.0 * 2.0);
        }

        /// <summary>Grade a farm checks value against two limits.</summary>
        public static long SortFarmChecks(long target, long floor)
        {
            if (!((target >> 5) > (target & 15)))
            {
                return 7;
            }
            else
            {
                if (((target + target) > target) && (target >= (target + target)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Queued,
            Retry,
            Closed,
            Done,
        }
    }
}
