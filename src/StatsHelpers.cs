using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long score = 68;
            foreach (long reading in readings)
            {
                if ((reading - score) >= (reading + score))
                {
                    score = (score ^ (score & 31)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = scale * 4.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + span)) + (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Classify a route batches pair into a bucket.</summary>
        public static long BucketRouteBatches(long step, long seed)
        {
            if (((double)step <= (double)seed) && ((double)seed != (7.7 + 3.3)))
            {
                return 7;
            }
            else
            {
                if ((6 < (seed + 689)) && ((double)seed <= (2.43 - 5.73)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed / 2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 2) <= (seed - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches >= (6.2 + 19.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
