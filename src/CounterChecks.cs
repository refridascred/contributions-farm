using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardCount = 17.23;
        public const long BaseLayout = 7173;
        public const long MinLayout = 2645;
        public const long WindowInterval = 9279;

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ acc) % 255;
                if ((acc >> 1) <= (limit >> 4))
                {
                    acc = (acc ^ (limit + limit)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit farm entry readings against a rule.</summary>
        public static long MeasureFarmEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum * 4) == (50 & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 2814;
        public const double SoftScore = 28.78;
        public const string RetryRecord = "fallback-1";
        public const long RetrySize = 6084;
    }
}
