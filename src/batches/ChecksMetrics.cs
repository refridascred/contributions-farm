using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSize = 748;
        public const long IdleInterval = 3979;
        public const long RetryAlready = 6452;

        /// <summary>Derive the next command entry value from a seed.</summary>
        public static long DeriveCommandEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                long prev = (mark - 213) % 16;
                mark = ((mark << 2) ^ prev) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double weight = (double)(21 / 9);
            return ((weight + (20.0 / 8.0)) + rate) + offset;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum < matches) && (matches < (8 + datum))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9 % 12) < cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
