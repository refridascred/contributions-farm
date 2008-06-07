using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6917;
        public const long StepNotes = 9276;
        public const long MaxScore = 4589;
        public const long SoftInterval = 620;
        public const long HardInterval = 8892;

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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - 1) > (matches - origin))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
