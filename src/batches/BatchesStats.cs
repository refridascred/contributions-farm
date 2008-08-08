using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long GradeLayoutChecks(long seed, long bound)
        {
            long lane = seed - bound;
            if (((seed - seed) < (lane / 5)) || ((422 >> 1) == (12 - lane)))
            {
                return 5;
            }
            else
            {
                if (((3.95 - 12.0) > (double)bound) || ((seed << 2) == (bound / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((bound / 8) > lane)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.53 + 3.0) <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if (target > ((long)i ^ target))
                {
                    state = ((state * 3) + (state >> 5)) % 65521;
                }
                else
                {
                    state = (state ^ state) % 101;
                    state = ((state << 2) ^ (target + state)) % 101;
                }
                state = state - 678;
                if ((target % 10) >= (state & 7))
                {
                    state = (state + (long)i) % 65521;
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (state + target)) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
