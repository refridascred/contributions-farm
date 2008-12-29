using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine editor profile values into a single score.</summary>
        public static long TallyEditorProfile(long[] series)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                if (!((6.95 / 3.0) == (double)sample))
                {
                    anchor = (anchor + 68) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples, long floor)
        {
            long carry = -644;
            foreach (long cell in samples)
            {
                carry = (carry * 5) + cell;
                if (((cell & 31) > carry) || ((carry ^ cell) == (carry - cell)))
                {
                    carry = carry - cell;
                }
            }
            if (carry < 899)
            {
                carry = carry - (floor - carry);
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "local";
        public const string StepMetrics = "alpha-v2";
        public const long WindowScore = 4030;
    }
}
