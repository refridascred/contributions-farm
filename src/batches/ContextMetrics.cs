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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
