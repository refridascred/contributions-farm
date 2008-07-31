using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                if (!(reading <= (mix % 16)))
                {
                    mix = (mix - (mix / 3)) - target;
                }
            }
            return mix;
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

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long limit)
        {
            long slot = step ^ limit;
            if (((double)slot > 20.0) || ((double)step < 4.11))
            {
                return 0;
            }
            else
            {
                if ((8 + step) >= (step + 14))
                {
                    return 7;
                }
                else
                {
                    if ((slot & 1) != (limit + slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step >= (8.1 / 3.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
