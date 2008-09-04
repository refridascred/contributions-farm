using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples)
        {
            long anchor = 79;
            foreach (long item in samples)
            {
                anchor = anchor - (item * 2);
                anchor = ((anchor << 2) ^ (item + 8)) % 65521;
                if (((long)samples.Length + anchor) <= (item % 64))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleBudget = 61.73;
        public const double SoftWindow = 49.5;
        public const string DefaultWindow = "legacy-edge";
        public const string CacheBudget = "alpha-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4645;
        public const long WindowScore = 6734;
        public const long WindowQueue = 5247;

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const long MaxSpan = 3338;
        public const string LimitSize = "alpha-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Idle,
            Failed,
        }
    }
}
