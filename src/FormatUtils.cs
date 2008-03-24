using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double drift = (offset * 2.0) * 5.51;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (2.6 - offset)) + (double)(long)i) - rate;
            }
            return drift + (offset * 17.0);
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long CountMetricStreamHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((step & 31) > (-97)) && (((double)matches == (0.45 * 5.9)) || ((double)(long)items.Length == (double)46)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes cache pair into a bucket.</summary>
        public static long RankNotesCache(long limit, long bound)
        {
            if (!(limit <= (bound + 815)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > bound)
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 2) ^ 0) % 97;
                if ((double)(long)i == (4.0 - 17.0))
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((0.9 / 4.0) > (double)item) && ((double)hits > (2.8 + 6.0))) && ((hits > (floor ^ 66)) || ((1.4 / 5.0) <= 8.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((0.5 + 1.9) < (double)offset) && ((7.35 + 12.0) != (double)sum))
                {
                    sum = (sum - (55 ^ (long)i)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
