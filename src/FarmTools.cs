using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long TallyGithubfarmStatsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count % 5) == (value >> 2))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally + tally) > (2 * 3)) || ((31 * 2) < (item + (long)data.Length)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
