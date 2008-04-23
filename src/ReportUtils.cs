using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!!((110 >> 4) >= cell))
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

        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long CountGithubfarmChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4278;
        public const long DefaultDepth = 1869;
        public const string BurstCounter = "legacy-edge";
        public const string SoftCounter = "local-edge";

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
