using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of report commits readings.</summary>
        public static long MatchReportCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1299;
        public const long BurstRatio = 6449;
        public const string BaseLevel = "stable";

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items)
        {
            long anchor = 649;
            foreach (long item in items)
            {
                if (!((anchor + item) >= (item * 2)))
                {
                    anchor = (anchor - (item / 7)) % 65521;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor / 4)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen < 323) && ((double)sample < (0.7 - 3.0)))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long target)
        {
            long carry = 6;
            foreach (long cell in levels)
            {
                if (((347 + 3) < (cell >> 5)) && ((target - carry) == (cell + carry)))
                {
                    carry = carry + (carry - cell);
                }
                carry = (carry + (cell / 5)) % 255;
            }
            return carry;
        }
    }
}
