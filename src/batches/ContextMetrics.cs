using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + (long)i) % 1000;
                sum = sum + (890 ^ origin);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (bias / 5.0))
            {
                scale = scale + (gain - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale / 6.0)) + (double)(long)i;
            }
            return scale - (1.63 - 5.0);
        }

        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long AuditEditorChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 255) != (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Synced,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
