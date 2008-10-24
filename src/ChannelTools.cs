using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (limit > (limit - 0))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long anchor = 96;
            foreach (long value in items)
            {
                anchor = anchor ^ (51 + 929);
                anchor = anchor ^ (anchor - value);
                if (5 <= (anchor + 87))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
