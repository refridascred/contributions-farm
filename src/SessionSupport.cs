using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the context order entries that pass the check.</summary>
        public static long MeasureContextOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches > (matches + matches)) && ((-3) <= (sample - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long bound)
        {
            long gap = offset - bound;
            if (gap >= (gap >> 5))
            {
                return 2;
            }
            else
            {
                if (!((547 ^ gap) != (677 + 2)))
                {
                    return 7;
                }
                else
                {
                    if (offset < (gap * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
