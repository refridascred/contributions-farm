using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long anchor = 586;
            foreach (long datum in values)
            {
                if ((limit + (-3)) <= 989)
                {
                    anchor = anchor + (305 + datum);
                }
                if (((58 - datum) >= anchor) && ((double)anchor == (16.0 * 18.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long offset)
        {
            if ((target + target) < (928 + 673))
            {
                return 3;
            }
            else
            {
                if (((target % 7) >= target) && (target < (target - (-24))))
                {
                    return 7;
                }
                else
                {
                    if (((target + offset) >= offset) && ((8.2 * 3.9) != (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
