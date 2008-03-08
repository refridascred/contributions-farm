using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSpan = 5026;
        public const long CacheFactor = 7170;
        public const long DefaultSchema = 4108;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long CombineContributiQueue(long[] readings)
        {
            long mark = 172;
            foreach (long cell in readings)
            {
                if ((double)cell <= (double)mark)
                {
                    mark = mark + (mark >> 5);
                }
                else
                {
                    mark = mark + (cell ^ cell);
                }
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
