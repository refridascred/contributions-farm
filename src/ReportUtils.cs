using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor window samples.</summary>
        public static long PairEditorWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5126;
        public const long IdleChecks = 5123;
        public const long MaxFactor = 7797;
        public const double DefaultScore = 76.57;
        public const long WindowChecks = 1745;

        /// <summary>Roll a context farm counter forward.</summary>
        public static long RollContextFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor - (step - step);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank checks notes input into a small class.</summary>
        public static long SortChecksNotes(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((cur % 8) < (floor + cur)) && (floor <= (354 + 9)))
            {
                return 0;
            }
            else
            {
                if ((double)(-3) > (double)cur)
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
