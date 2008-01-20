using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double ratio = (scale * 6.2) / 7.0;
            if (ratio < scale)
            {
                ratio = (ratio - (double)631) - bias;
            }
            return ratio + (double)85;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double gain = (double)(35 << 1);
            return (gain + weight) + span;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            New,
            Stale,
            Dropped,
            Queued,
            Locked,
        }
    }
}
