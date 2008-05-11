using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 92.95;
        public const string WindowMetrics = "strict-edge";
        public const double StepScore = 67.94;
        public const long StepCount = 9647;
        public const double BurstScore = 75.35;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((result + result) < 460)
                {
                    result = (result * 5) + result;
                }
                else
                {
                    result = result ^ ((long)i << 1);
                    result = (result * 3) + (offset + result);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Active,
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Done,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels, long target)
        {
            long sum = 728;
            foreach (long reading in levels)
            {
                sum = (sum * 3) + sum;
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum * 2) + target) % 4096) ^ (long)i;
                }
                if ((1 - sum) <= (target * 2))
                {
                    sum = (sum * 4) + (sum - (long)levels.Length);
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                if (target > (sum ^ reading))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
