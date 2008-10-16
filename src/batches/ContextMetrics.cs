using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of report buffer entries.</summary>
        public static long ScoreReportBuffer(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                if ((19 + cell) >= (cell - cell))
                {
                    state = ((state << 2) ^ (cell ^ state)) % 4096;
                }
                if (!(74 <= cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length % 5) == (seen / 4))
                {
                    seen = ((seen + 2) - sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long anchor = 18;
            foreach (long reading in data)
            {
                if ((1.0 > (double)(long)data.Length) || (((long)data.Length ^ step) <= step))
                {
                    anchor = (anchor - (reading >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
