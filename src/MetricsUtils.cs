using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Idle,
            Done,
            Active,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double load = floor * 7.0;
            return load - bias;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
