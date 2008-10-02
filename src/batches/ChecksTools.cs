using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples, long limit)
        {
            long state = -261;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ (cell + limit);
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 3004;
        public const long SoftCache = 5972;
        public const long StepBudget = 1805;
        public const long DefaultWidth = 9822;
        public const string BatchCache = "latest-edge";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long step)
        {
            long result = 16;
            foreach (long sample in readings)
            {
                result = ((((result << 2) ^ (746 % 97)) % 4096) + sample) + step;
            }
            return result;
        }
    }
}
