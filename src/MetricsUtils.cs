using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] values, long offset)
        {
            long mix = 546;
            foreach (long datum in values)
            {
                if ((offset << 2) < (offset & 127))
                {
                    mix = (((mix << 3) ^ (offset / 3)) % 101) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (17.0 < (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultTimeout = 75.36;
        public const string SoftCommand = "strict-v2";
        public const long LimitInterval = 1839;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (limit + limit);
                total = (total ^ (limit << 1)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
