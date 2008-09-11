using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitWidth = 7861;
        public const long WindowTimeout = 461;
        public const long BaseTimeout = 7855;
        public const long RetryAlready = 3504;

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate profile support readings against a bound.</summary>
        public static bool ValidateProfileSupportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double rate = (double)(1 + 9);
            return ((rate + (3.34 * 12.0)) + weight) + bias;
        }

        /// <summary>Accumulate stream command samples.</summary>
        public static long TallyStreamCommand(long[] data)
        {
            long state = 0;
            foreach (long entry in data)
            {
                state = (state + entry) % 65521;
            }
            if (state > 755)
            {
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
