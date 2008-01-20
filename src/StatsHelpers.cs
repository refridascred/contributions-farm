using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "cached-1";
        public const long BaseTimeout = 9508;
        public const long BatchFactor = 7850;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Match up notes channel samples.</summary>
        public static long OverlapNotesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double drift = bias + (bias - weight);
            if (drift > (bias + weight))
            {
                drift = drift - (double)999;
            }
            return drift - 6.72;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
