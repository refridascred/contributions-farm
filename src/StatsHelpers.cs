using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many format payload samples are out of range.</summary>
        public static long AuditFormatPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((38 << 2) <= (reading + (-221)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache farm samples.</summary>
        public static long TallyCacheFarm(long[] items, long offset)
        {
            long acc = 30;
            foreach (long value in items)
            {
                if ((1.4 / 7.0) >= (9.71 + 4.9))
                {
                    acc = ((acc * 3) + value) % 97;
                }
                else
                {
                    acc = ((acc * 3) + offset) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long step)
        {
            long next = floor + step;
            if ((6.0 + 1.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if (!((floor % 7) == (next / 6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 1211;
        public const string MaxFilter = "open-1";
        public const double LimitFilter = 21.67;
        public const string LimitBudget = "open-v2";
        public const double BatchScore = 31.6;
    }
}
