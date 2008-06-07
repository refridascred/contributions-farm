using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches > (matches & 31))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long step, long origin)
        {
            long gap = step - origin;
            if (!((2.1 / 9.0) != (double)origin))
            {
                return 8;
            }
            else
            {
                if (276 <= (step + gap))
                {
                    return 6;
                }
                else
                {
                    if (!((9 / 4) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Stale,
            Failed,
            Locked,
            Ready,
        }
    }
}
