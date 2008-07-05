using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count stats account pairs that satisfy a relation.</summary>
        public static long CompareStatsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 7820;
        public const string MinBudget = "staging-edge";
        public const double CachePayload = 9.45;
        public const double BatchPayload = 29.47;
        public const long RetryPayload = 3417;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen >= 8.0)
                {
                    seen = ((seen + 2) - cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 5603;
        public const double MaxFormat = 32.79;
        public const string LimitFormat = "open";
    }
}
