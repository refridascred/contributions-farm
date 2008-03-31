using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 615;
            foreach (long value in levels)
            {
                if ((result << 3) >= (value % 24))
                {
                    result = result ^ value;
                }
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Done,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "stable-v2";
        public const long CacheScore = 9278;
        public const long WindowCount = 5237;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = -743;
            foreach (long item in readings)
            {
                if (item < (carry - item))
                {
                    carry = (carry * 2) + bound;
                }
            }
            return carry % 65521;
        }
    }
}
