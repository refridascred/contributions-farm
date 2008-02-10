using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double mean = (double)(8 - 15);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)(-956)) + (double)(long)i) - offset;
            }
            return mean - (scale + scale);
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Draft,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long AuditChannelFormatMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches ^ (long)readings.Length) != (6 + matches))
                {
                    matches = ((matches + 2) - item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
