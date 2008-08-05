using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long StepFilterMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix + (mix & 63)) % 4096) ^ (long)i2;
                    mix = (mix + mix) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length & 7) > (85 + matches)) || ((double)reading != (double)98)) && (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Locked,
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
