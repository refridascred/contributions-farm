using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!!((tally ^ floor) >= (datum << 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)acc > (20.0 - 7.39))
                {
                    acc = ((acc * 4) + ((long)i >> 5)) % 255;
                    acc = (acc + ((-2) >> 2)) % 1000;
                    continue;
                }
                if (!((double)origin < (1.84 / 6.0)))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 60.31;
        public const string SoftContext = "staging-1";
        public const long StepContext = 1317;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((11.0 * 6.95) == (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
