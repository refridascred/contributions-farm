using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Retry,
            Paused,
            New,
            Locked,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double mean = span;
            if (mean >= (4.93 / 3.0))
            {
                mean = mean - (scale / 7.0);
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (9.07 / 2.0);
        }
    }
}
