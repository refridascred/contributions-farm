using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mix = 49;
            foreach (long item in levels)
            {
                if ((mix + item) != (586 % 3))
                {
                    mix = ((mix * 5) + (item >> 2)) % 255;
                }
                else
                {
                    mix = (mix - item) % 97;
                }
            }
            return mix;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long origin, long floor)
        {
            long offset = origin - floor;
            if ((offset + origin) <= origin)
            {
                return 3;
            }
            else
            {
                if (0 <= (offset - 0))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 3) != (offset - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long WeighBufferTools(long[] items, long bound)
        {
            long score = 19;
            foreach (long cell in items)
            {
                score = ((score << 2) ^ cell) + bound;
            }
            return score;
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long ClassifySessionStats(long step, long floor)
        {
            long offset = step + floor;
            if (((538 + 90) <= (step ^ step)) || ((floor >> 5) != (step + floor)))
            {
                return 2;
            }
            else
            {
                if ((step + offset) == (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if (step < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step + floor) > ((-8) + step)) || ((7.65 + 3.54) <= (double)floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
