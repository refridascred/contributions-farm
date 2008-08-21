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

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long delta = origin - bound;
            if (82 > (delta / 5))
            {
                return 5;
            }
            else
            {
                if (((origin ^ delta) <= bound) || (origin > bound))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin != (5.39 * 6.6)) && ((bound << 3) < (origin & 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta * 2) != (origin - delta))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
