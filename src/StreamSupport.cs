using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long score = -7;
            foreach (long sample in readings)
            {
                if (79 > floor)
                {
                    score = (score + floor) - sample;
                }
                if ((score - score) <= score)
                {
                    score = (score ^ 283) % 65521;
                }
                if ((score >> 5) <= (808 >> 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
