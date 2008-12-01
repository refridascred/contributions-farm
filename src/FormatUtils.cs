using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (limit << 3)) % 255;
                acc = (acc ^ (limit ^ limit)) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value - floor) == (value + value)) || ((tally + 50) <= value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route counter value from a seed.</summary>
        public static long RollRouteCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (seed - seed)) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
