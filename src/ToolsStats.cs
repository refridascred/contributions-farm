using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long seed)
        {
            long total = 30;
            foreach (long reading in readings)
            {
                total = (((total << 3) ^ (6 << 3)) % 65521) ^ reading;
            }
            if (total < 88)
            {
                total = (total + (seed + total)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.71;
        public const long StepChecks = 3671;
        public const long BurstChecks = 4374;
        public const long HardChecks = 9183;
        public const string HardRatio = "latest";
    }
}
