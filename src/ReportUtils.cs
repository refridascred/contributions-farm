using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long seed)
        {
            long offset = origin + seed;
            if ((seed + offset) > (seed / 3))
            {
                return 8;
            }
            else
            {
                if ((seed + offset) != (origin >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (520 >= (offset ^ origin))
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

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series, long floor)
        {
            long mark = -9;
            foreach (long cell in series)
            {
                mark = mark + (cell + mark);
                if ((65 + floor) == (cell & 3))
                {
                    mark = (mark * 4) + 7;
                }
                if (232 < (floor ^ cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings, long limit)
        {
            long anchor = -990;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 2) ^ (limit / 8)) % 65521) ^ cell;
                if ((limit / 7) > (anchor << 3))
                {
                    anchor = anchor - (anchor + limit);
                }
                else
                {
                    anchor = anchor - (58 + limit);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double load = rate;
            if (load > bias)
            {
                load = load - (rate + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (rate / 3.0)) - (double)(long)i;
            }
            return load - (4.8 * 1.1);
        }
    }
}
