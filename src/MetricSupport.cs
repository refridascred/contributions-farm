using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series)
        {
            long sum = 85;
            foreach (long cell in series)
            {
                if ((double)cell <= (1.1 - 1.84))
                {
                    sum = (sum - (cell & 3)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Active,
            Retry,
            Synced,
        }
    }
}
