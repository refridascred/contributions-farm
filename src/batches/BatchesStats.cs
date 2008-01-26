using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next command already value.</summary>
        public static double ScaleCommandAlready(double bias, double offset)
        {
            double drift = (double)(9 + 19);
            if (drift < (offset - drift))
            {
                drift = drift + (drift + 7.09);
            }
            else
            {
                drift = drift + (bias * 13.0);
            }
            return drift + offset;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open";
        public const long BaseLayout = 1378;
        public const string StepInterval = "strict";
        public const string BurstLayout = "alpha-1";
        public const string BaseWidth = "local";

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
