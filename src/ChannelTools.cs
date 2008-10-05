using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 35.53;
        public const string IdleContext = "standard-edge";
        public const long HardLevel = 4496;
        public const string IdleDepth = "fallback";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)hits <= 2.17) || ((192 >= value) && ((long)data.Length != (value + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
