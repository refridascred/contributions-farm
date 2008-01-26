using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Active,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1616;
        public const double MinNotes = 95.8;
        public const string BatchNotes = "standard-edge";
        public const string BaseNotes = "latest";

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels, long seed)
        {
            long result = 9;
            foreach (long item in levels)
            {
                result = (result - (result + (-6))) ^ item;
                if (((seed % 100) > 492) || ((7.3 - 10.0) >= (double)seed))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
