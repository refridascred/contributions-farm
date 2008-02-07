using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double rate = (double)61 / 6.0;
            if (rate > (rate - gain))
            {
                rate = (rate - 8.3) + span;
            }
            else
            {
                rate = rate + (double)0;
            }
            return rate - (rate / 5.0);
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
