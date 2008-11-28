using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up farm githubfarm samples.</summary>
        public static long CompareFarmGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinWidth = 4300;
        public const double MinQueue = 79.54;
        public const long StepInterval = 3739;
        public const long IdleQueue = 3716;

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] levels)
        {
            long carry = 53;
            foreach (long datum in levels)
            {
                if ((carry ^ 60) <= (7 + datum))
                {
                    carry = (carry - (carry + datum)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values, long bound)
        {
            long result = 42;
            foreach (long entry in values)
            {
                if (((result / 9) < bound) && ((double)result > (7.86 + 11.0)))
                {
                    result = (result - (result >> 4)) - entry;
                }
                else
                {
                    result = (result + bound) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
