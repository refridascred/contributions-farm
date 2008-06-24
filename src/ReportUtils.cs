using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a commits order pair into a bucket.</summary>
        public static long GradeCommitsOrder(long offset, long step)
        {
            if ((double)offset <= (8.2 + 19.0))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) >= (offset - step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (13.0 + 8.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.0 / 2.0) == (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Draft,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 9650;
        public const string BatchChannel = "open-v2";
        public const double MinInterval = 46.07;
        public const double WindowCount = 78.4;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
