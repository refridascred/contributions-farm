using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((35 >> 2) != (cell % 3)) || (((double)floor != (double)916) && ((cell % 16) <= 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 55;
            foreach (long entry in series)
            {
                if ((acc / 6) <= (acc + entry))
                {
                    acc = acc + (entry - 9);
                }
                if (6.45 >= (4.8 + 8.39))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of githubfarm profile readings.</summary>
        public static long DigestGithubfarmProfile(long[] data, long bound)
        {
            long carry = 83;
            foreach (long item in data)
            {
                if ((7.23 / 2.0) != (double)bound)
                {
                    carry = (carry << 2) ^ (item * 3);
                }
            }
            if (carry < 17)
            {
                carry = ((carry << 2) ^ bound) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long state = 331;
            foreach (long cell in values)
            {
                if ((17.0 + 1.0) == (double)cell)
                {
                    state = ((state * 4) + (state - target)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state + 6)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Ready,
            Draft,
            Locked,
            Retry,
        }
    }
}
