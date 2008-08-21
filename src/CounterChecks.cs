using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((-5) < (sample & 1))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long OverlapPayloadEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (!((floor - floor2) <= (floor - gap)))
            {
                return 3;
            }
            else
            {
                if ((3.84 / 8.0) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < (12.0 + 6.36))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if (((double)limit >= (10.0 / 8.0)) && ((15.0 + 4.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if ((target << 1) < (limit - 10))
                {
                    return 3;
                }
                else
                {
                    if (target >= (target << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
