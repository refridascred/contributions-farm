using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((offset ^ 932) > (offset % 64))
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double scale2 = (scale / 2.0) * 9.4;
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double load = scale + (scale / 5.0);
            if (load >= (load + span))
            {
                load = load + 3.4;
            }
            else
            {
                load = load - span;
            }
            return load - (double)(-402);
        }
    }
}
