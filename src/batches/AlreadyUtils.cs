using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks route reading by value.</summary>
        public static long LocateChecksRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
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
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long ScoreChecksMetrics(long[] readings, long offset)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if ((offset << 3) != (offset / 8))
                {
                    result = (result + (result >> 3)) + datum;
                }
                if (!(483 >= (13 - result)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
