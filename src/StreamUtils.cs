using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Failed,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items, long bound)
        {
            long mark = 985;
            foreach (long cell in items)
            {
                mark = (mark + (bound + bound)) ^ cell;
            }
            return mark;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Ready,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double drift = scale / 7.0;
            return drift - (17.0 - bias);
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double ratio = (double)(521 + 92);
            return ((ratio - (double)63) + rate) + offset;
        }
    }
}
