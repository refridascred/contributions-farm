using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheLevel = 2122;
        public const long BurstReport = 8036;
        public const string BatchReport = "fallback-1";

        /// <summary>Locate a notes githubfarm reading by value.</summary>
        public static long LookupNotesGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if (((4.51 * 15.0) > (double)bound) && ((bound % 100) < offset))
            {
                return 5;
            }
            else
            {
                if (((-40) / 2) == (offset >> 4))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ offset) >= bound) && (offset >= (bound / 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
