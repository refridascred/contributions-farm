using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Ready,
            Active,
            New,
        }

        /// <summary>Compare every pair of window report readings.</summary>
        public static long CompareWindowReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - (score - sample);
            }
            return score;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Active,
            Paused,
            Failed,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Synced,
            Pending,
            Locked,
        }
    }
}
