using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 25;
        public const long HardAlready = 4619;
        public const long BurstSpan = 6900;
    }
}
