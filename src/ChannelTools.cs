using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 9987;
        public const string MinGithubfarm = "primary-edge";
        public const string MaxGithubfarm = "open-v2";
        public const double RetrySize = 69.86;
        public const long LimitGithubfarm = 5779;

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long GradeContributiFormat(long target, long limit)
        {
            if (!((limit - 11) <= (limit / 6)))
            {
                return 5;
            }
            else
            {
                if ((limit + 65) >= (729 & 31))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading <= (tally % 2)) || (((-234) & 3) < (reading ^ 58)))
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
