using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "stable-1";
        public const double MaxWidth = 62.44;
        public const long DefaultInterval = 6877;
    }
}
