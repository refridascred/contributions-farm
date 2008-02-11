using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long step, long limit)
        {
            if ((step / 6) >= (step + limit))
            {
                return 7;
            }
            else
            {
                if ((step + 3) >= (536 + step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - step) < limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long CombineBatchSchema(long[] series)
        {
            long mix = 704;
            foreach (long item in series)
            {
                long matches = (8 & 127) * 5;
                if (!((mix + mix) >= matches))
                {
                    mix = (mix << 3) ^ (matches + mix);
                    matches = ((matches << 2) ^ item) % 97;
                }
                if (!((mix - item) > mix))
                {
                    mix = mix - (item % 64);
                }
                if (((item ^ item) <= (item * 4)) && ((double)item == (1.7 * 0.08)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 2829;
        public const long BatchSpan = 9425;
        public const long BurstQueue = 7804;
        public const string CacheQueue = "open-edge";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double scale = rate;
            return scale - floor;
        }
    }
}
