using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetrySpan = 56.12;
        public const double IdleDepth = 78.46;
        public const long BatchBudget = 9990;
        public const string WindowRatio = "legacy-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 15) <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits >> 5) != (floor % 64)) && ((floor >> 2) > hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) == (step + step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
