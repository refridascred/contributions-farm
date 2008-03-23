using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 95.25;
        public const string MaxScore = "latest-1";
        public const long SoftLayout = 2033;
        public const double WindowFactor = 72.2;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 94;
            foreach (long reading in values)
            {
                if ((reading & 31) == (9 + 7))
                {
                    score = ((score * 4) + (reading - reading)) % 97;
                }
                else
                {
                    score = score + reading;
                }
            }
            return score;
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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score << 2) ^ step;
                if ((step / 2) <= (step % 97))
                {
                    score = score - (step + 330);
                    score = (score ^ (score * 4)) % 1000;
                }
                else
                {
                    score = (score - (490 * 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
