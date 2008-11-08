using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > 1.4)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Closed,
            Done,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long MeasureCacheWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value - hits) >= value) && ((value & 255) > (3 - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long FoldBufferGithubfarm(long[] levels, long offset)
        {
            long state = -962;
            foreach (long value in levels)
            {
                if (offset < state)
                {
                    state = (state + (state ^ value)) % 65521;
                }
            }
            if (state > 521)
            {
                state = (state * 2) + (state % 100);
            }
            return state % 65521;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long target)
        {
            long gap = origin + target;
            if (4.62 > (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= 55)
                {
                    return 7;
                }
                else
                {
                    if ((origin + target) >= (-42))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + origin) != (origin ^ origin)) || ((origin * 3) < (gap & 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
