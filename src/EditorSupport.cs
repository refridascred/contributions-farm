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

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 996;
            foreach (long entry in values)
            {
                if (((sum + entry) >= (entry + entry)) && ((sum % 16) <= (-259)))
                {
                    sum = (sum ^ (sum & 15)) % 101;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum - 766)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total - (long)i) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
