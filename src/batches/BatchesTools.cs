using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Active,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long offset)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if (reading >= (reading / 9))
                {
                    score = ((score - reading) % 65521) - offset;
                }
                if ((reading << 2) <= (85 % 16))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((double)gap < (5.9 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 98) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (seed > (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
