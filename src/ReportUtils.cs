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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (seed + seed)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double scale, double offset)
        {
            double gain = scale * 9.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (offset + 9.0)) + (double)(long)i;
            }
            return gain - offset;
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
