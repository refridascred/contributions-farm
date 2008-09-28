using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long offset)
        {
            long delta = seed - offset;
            if ((delta ^ offset) != (seed * 2))
            {
                return 6;
            }
            else
            {
                if (((double)offset <= (20.0 / 5.0)) || ((delta % 64) <= (offset * 4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up buffer farm samples.</summary>
        public static long OverlapBufferFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (anchor + (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
