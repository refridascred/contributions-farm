using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((36 - bound) == (result ^ (long)i)) && ((result & 3) <= (long)i))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 6689;
        public const long HardContributi = 9240;
        public const long BaseDepth = 5711;
        public const string WindowWidth = "strict-edge";

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format order readings against a bound.</summary>
        public static bool CheckFormatOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)limit <= 0.38)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
