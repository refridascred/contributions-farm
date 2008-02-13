using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) == (floor - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Closed,
            Active,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                state = (state * 2) + (sample % 12);
                if (((sample * 3) < (state % 12)) || ((double)sample > 5.1))
                {
                    state = (state * 2) + (11 * 4);
                }
                else
                {
                    state = (state + (state << 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double drift = (double)5;
            if (drift < (double)249)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift - (drift / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (rate / 8.0)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
