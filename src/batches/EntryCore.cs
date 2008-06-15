using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < 656)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Queued,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = offset;
            return bias - (scale * 6.73);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
