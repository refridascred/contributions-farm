using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long step)
        {
            if ((double)889 == (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step <= (step ^ seed)) || ((seed - seed) != (step % 60)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 / 9.0) <= (double)step) && ((step * 2) > 89))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the layout graph entries that pass the check.</summary>
        public static long MeasureLayoutGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((638 / 8) <= ((long)samples.Length + matches)) && ((matches - matches) > (matches >> 5))) && ((entry + matches) >= (matches >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool VerifyEntryRouteRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen >= limit) || ((cell + seen) <= (cell << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Active,
            Locked,
        }
    }
}
