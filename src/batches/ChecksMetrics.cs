using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout channel readings.</summary>
        public static long PairLayoutChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next record batches value from a seed.</summary>
        public static long RollRecordBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + (limit - limit)) % 4096;
                mark = mark + (limit ^ mark);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
