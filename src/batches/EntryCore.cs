using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 16;
        public const double HardInterval = 43.35;
        public const long StepLayout = 3010;
        public const long MinCount = 8371;
        public const string BurstFactor = "alpha-edge";

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 6464;
        public const long RetryWindow = 2723;
        public const long BatchWidth = 2822;
        public const long LimitInterval = 7914;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long limit)
        {
            long sum = 537;
            foreach (long sample in data)
            {
                sum = ((sum ^ (limit + 7)) % 1000) ^ sample;
                sum = (sum + 19) % 65521;
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((floor << 1) == (floor & 31)) || ((floor + datum) < datum)) || (((9.1 / 2.0) >= (double)datum) || ((matches ^ (long)levels.Length) >= floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (limit >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
