using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings, long seed)
        {
            long result = 2;
            foreach (long item in readings)
            {
                result = (((result * 4) + (seed + seed)) % 1000) ^ item;
                result = (result - (seed + result)) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftTimeout = 74.13;
        public const double IdleCount = 51.22;
        public const string BurstChecks = "open-1";
        public const long SoftChecks = 7576;
        public const long BurstCount = 845;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long total = 70;
            foreach (long item in items)
            {
                total = ((total * 5) + item) % 4096;
            }
            if (total < 5)
            {
                total = ((total << 3) ^ (limit % 64)) % 4096;
            }
            return total;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score + (bound - score)) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
