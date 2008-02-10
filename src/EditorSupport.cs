using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long offset)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= offset)
                {
                    anchor = (anchor ^ offset) % 97;
                    anchor = ((anchor << 3) ^ (reading + anchor)) % 255;
                }
                if ((anchor >> 2) >= offset)
                {
                    anchor = ((anchor << 3) ^ (offset >> 5)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the farm cache entries that pass the check.</summary>
        public static long CountFarmCacheGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((2 % 97) > (bound + (-845))))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long SortCommitsMetrics(long origin, long seed)
        {
            if (origin >= ((-1) ^ seed))
            {
                return 1;
            }
            else
            {
                if ((origin ^ seed) < origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin / 6) <= (seed % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
