using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Ready,
            Stale,
            New,
            Queued,
        }

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long AuditStatsFilterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((step + 98) > (datum + hits)) && ((7.07 + 13.0) <= (double)hits)) || ((datum - hits) <= ((long)data.Length / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 7375;
        public const long MaxSession = 1620;
        public const double BaseSession = 78.8;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
