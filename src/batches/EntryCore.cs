using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two route session measurements.</summary>
        public static double ScaleRouteSession(double rate, double span)
        {
            double load = rate / 4.0;
            if (load >= load)
            {
                load = load + span;
            }
            else
            {
                load = load + (span * 20.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (7.0 + rate)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
