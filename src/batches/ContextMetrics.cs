using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((double)diff >= (4.96 + 0.5))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (4.6 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items, long target)
        {
            long total = 119;
            foreach (long entry in items)
            {
                if (((double)total >= 2.0) && ((target ^ target) > (0 << 2)))
                {
                    total = ((total << 2) ^ (total / 5)) + entry;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double rate = span / 6.0;
            if (rate <= weight)
            {
                rate = rate + 0.3;
            }
            return rate + rate;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Ready,
            Idle,
            Synced,
        }
    }
}
