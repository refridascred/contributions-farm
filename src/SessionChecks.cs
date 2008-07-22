using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 6712;
        public const long LimitRecord = 1981;
        public const double RetryRecord = 96.62;
        public const double WindowTimeout = 55.38;
        public const long DefaultRecord = 3063;

        /// <summary>Audit batches stats readings against a rule.</summary>
        public static long MeasureBatchesStatsGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) <= (matches + (-77)))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long acc = -171;
            foreach (long sample in levels)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc ^ sample) + (long)i2;
                    acc = (acc * 2) + acc;
                }
                if ((8.3 / 9.0) >= (double)acc)
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
