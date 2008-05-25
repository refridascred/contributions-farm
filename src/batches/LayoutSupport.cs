using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double AdjustMetricsStream(double rate, double span)
        {
            double ratio = (span + rate) / 7.0;
            return ratio + (3.93 * 14.0);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                if (datum < state)
                {
                    state = state - state;
                }
                if (((state + (long)samples.Length) != (datum ^ state)) || ((1.0 - 0.03) <= (double)state))
                {
                    state = (state - (state + state)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (state / 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (double)((-825) << 3);
            return (drift - (bias + 0.6)) + ratio;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
