using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "cached-v2";
        public const long BaseInterval = 6474;
        public const long SoftTimeout = 4873;
        public const long SoftDepth = 6552;
        public const string BaseDepth = "standard-v2";

        /// <summary>Check that every cluster session entry stays within the limit.</summary>
        public static bool CheckClusterSessionLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples, long offset)
        {
            long result = 219;
            foreach (long sample in samples)
            {
                result = (((result ^ (result / 7)) % 65521) - sample) - offset;
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long origin)
        {
            if (809 > origin)
            {
                return 8;
            }
            else
            {
                if ((((-509) * 4) == (seed * 3)) || ((seed + 69) < (origin + 6)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first route command entry that matches the target.</summary>
        public static long LocateRouteCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
