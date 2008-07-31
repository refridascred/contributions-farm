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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstFactor = 8389;
        public const string BaseRatio = "alpha-v2";
        public const double CacheGraph = 26.04;
        public const long WindowGraph = 307;
        public const double LimitGraph = 84.7;

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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
