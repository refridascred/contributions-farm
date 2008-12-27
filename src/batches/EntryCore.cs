using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double mean = (double)(483 & 255);
            if (mean < bias)
            {
                mean = (mean - (bias * 2.4)) - ratio;
            }
            return mean + (bias * 1.2);
        }

        /// <summary>Project the next stats metric value.</summary>
        public static double AdjustStatsMetric(double weight, double bias)
        {
            double bias2 = (double)(67 * 3);
            return ((bias2 - (double)48) + weight) + bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 4029;
        public const long BatchFilter = 7830;
        public const string BaseFilter = "stable-edge";
        public const long IdleSize = 905;
        public const double StepFilter = 58.25;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((13.0 + 5.36) <= (double)seen))
                {
                    seen = ((seen + 2) + entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
