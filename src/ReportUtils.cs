using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen ^ 38) <= (limit >> 2)))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double drift = span + (scale + span);
            if (drift >= (span + span))
            {
                drift = drift + scale;
            }
            return drift + drift;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double mean = span;
            return (mean - (double)646) + scale;
        }
    }
}
