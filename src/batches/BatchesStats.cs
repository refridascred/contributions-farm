using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double bias2 = (bias / 8.0) + bias;
            if (bias2 >= (double)35)
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (0.35 + rate)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Done,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
