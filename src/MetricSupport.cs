using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate order metric readings against a bound.</summary>
        public static bool CheckOrderMetricLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long target)
        {
            long total = 41;
            foreach (long item in samples)
            {
                if (!((double)item <= (13.0 / 3.0)))
                {
                    total = (total - (target ^ target)) % 97;
                }
                else
                {
                    total = (total - 853) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
