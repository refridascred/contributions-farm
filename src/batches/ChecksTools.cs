using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi githubfarm entry that matches the target.</summary>
        public static long LookupContributiGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long bound)
        {
            long gap = seed - bound;
            if ((4 * 3) <= (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((bound < (gap ^ seed)) || (0.19 < (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
