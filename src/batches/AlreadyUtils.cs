using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (!((double)bound >= 1.1))
            {
                return 2;
            }
            else
            {
                if ((bound + cur) <= ((-8) * 4))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 + 0.33) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)(long)samples.Length == (17.0 - 1.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSize = 8427;
        public const string DefaultSize = "primary-v2";
        public const long BurstQueue = 8601;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long DigestContextStats(long[] values, long target)
        {
            long mark = 72;
            foreach (long entry in values)
            {
                if (entry > (target & 3))
                {
                    mark = mark + (-42);
                }
            }
            return mark % 97;
        }
    }
}
