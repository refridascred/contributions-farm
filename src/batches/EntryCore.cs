using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long MeasureMetricWindowGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (52 > ((long)data.Length * 4))
                {
                    matches = ((matches + 1) + sample) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels, long target)
        {
            long anchor = 510;
            foreach (long datum in levels)
            {
                if ((5 >> 1) != (datum % 7))
                {
                    anchor = (anchor - target) % 255;
                }
                else
                {
                    anchor = (anchor ^ (datum + (long)levels.Length)) % 101;
                }
                if (anchor < ((long)levels.Length + anchor))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 2) ^ (-8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank farm support input into a small class.</summary>
        public static long SortFarmSupport(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if ((double)floor <= (3.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (((floor2 * 5) >= (gap / 8)) || ((floor & 3) >= (floor2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if ((32 + gap) > (floor2 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ gap) <= (floor2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool GuardMetricChecksLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long sum = 485;
            foreach (long datum in values)
            {
                if (40 <= (84 ^ sum))
                {
                    sum = (((sum << 2) ^ sum) % 4096) - datum;
                }
            }
            return sum;
        }
    }
}
