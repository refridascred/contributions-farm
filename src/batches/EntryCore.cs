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

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) != (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
