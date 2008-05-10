using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings)
        {
            long sum = 38;
            foreach (long value in readings)
            {
                if ((5.2 / 5.0) != (double)(long)readings.Length)
                {
                    sum = ((sum << 3) ^ (sum / 2)) ^ value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record payload value from a seed.</summary>
        public static long RollRecordPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ (acc * 5);
                if ((1.2 + 20.0) >= (double)acc)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 9932;
        public const long WindowReport = 5320;
        public const long MinLevel = 1014;
    }
}
