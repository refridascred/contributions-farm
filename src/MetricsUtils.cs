using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((double)datum == (5.84 - 19.0)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long mix = 28;
            foreach (long cell in readings)
            {
                mix = ((mix + origin) % 65521) + cell;
            }
            if (mix < 3)
            {
                mix = (mix << 2) ^ 542;
            }
            return mix;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
