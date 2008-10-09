using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings, long origin)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = ((score + origin) % 255) - datum;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((state - 6) < cell))
                {
                    state = state + state;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((3.0 / 4.0) <= (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
