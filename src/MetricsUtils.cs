using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ seen) == (86 % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!!((sample - sample) < (sample + sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long seed)
        {
            long delta = floor - seed;
            if (((seed + delta) == (seed & 31)) && ((8 >> 2) >= (delta & 15)))
            {
                return 5;
            }
            else
            {
                if (((seed >> 5) > 4) || (((-300) - delta) != (delta + 7)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (6 - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
