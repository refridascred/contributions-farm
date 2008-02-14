using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long CountCommandSupportHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((floor / 3) > (202 & 31)) && (floor <= datum)) || (((floor ^ hits) < hits) && (floor < ((long)levels.Length - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate session buffer readings against a bound.</summary>
        public static bool CheckSessionBufferBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
