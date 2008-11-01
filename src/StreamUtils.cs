using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series)
        {
            long total = 57;
            foreach (long value in series)
            {
                if (0.5 > (double)total)
                {
                    total = (((total << 2) ^ (long)series.Length) % 1000) ^ value;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 26) == (seed >> 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 4164;
        public const string BurstFactor = "fallback-v2";
        public const long BatchFactor = 5688;
        public const long StepCommand = 8389;
        public const long LimitCommand = 8386;

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long CountCounterOrderOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((value & 1) != (count + count)) || ((double)value <= (8.6 * 5.0))) && ((value << 3) >= (value * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long seed)
        {
            long delta = step ^ seed;
            if ((298 - delta) < 51)
            {
                return 0;
            }
            else
            {
                if (((step + delta) >= (delta + 4)) || (seed > (delta + delta)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 547;
        public const double BaseLayout = 19.92;
        public const double BurstLayout = 97.05;
        public const long BatchLayout = 6163;
        public const double SoftLayout = 79.75;
    }
}
