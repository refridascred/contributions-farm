using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] readings, long floor)
        {
            long acc = -7;
            foreach (long entry in readings)
            {
                acc = ((acc - (acc - acc)) % 97) ^ entry;
                if (acc >= floor)
                {
                    acc = (acc * 3) + ((-35) + floor);
                }
                if ((floor - floor) < (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            long offset = limit + seed;
            if ((offset - limit) >= 8)
            {
                return 1;
            }
            else
            {
                if (((-232) ^ seed) <= (seed % 64))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit != (8.0 - 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of token command readings.</summary>
        public static long TotalTokenCommand(long[] data)
        {
            long anchor = 195;
            foreach (long value in data)
            {
                if (((6.0 / 8.0) < (double)anchor) || ((2.43 / 7.0) >= (double)value))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = ((anchor * 4) + value) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length >= (hits ^ hits)) || ((hits + value) == (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
