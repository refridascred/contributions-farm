using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double bias = (double)(7 / 8);
            if (bias < 2.8)
            {
                bias = ((bias + bias) + gain) - span;
            }
            else
            {
                bias = bias + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)362) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long mix = 17;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + reading;
                if ((bound << 1) == (bound / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
