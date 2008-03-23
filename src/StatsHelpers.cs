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

        /// <summary>Digest a series of batch support entries.</summary>
        public static long CombineBatchSupport(long[] series)
        {
            long mix = 365;
            foreach (long value in series)
            {
                if (((mix + 954) != (mix - mix)) || ((7.94 / 7.0) <= (double)value))
                {
                    mix = (mix << 3) ^ (value / 3);
                    continue;
                }
                else
                {
                    mix = (mix << 2) ^ (857 ^ mix);
                }
                if (7.03 <= (double)mix)
                {
                    mix = mix ^ (mix / 2);
                }
            }
            return mix % 65521;
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
