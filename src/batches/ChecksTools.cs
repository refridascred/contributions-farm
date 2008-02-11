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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long mark = 928;
            foreach (long sample in data)
            {
                if ((double)sample <= (double)floor)
                {
                    mark = ((mark << 2) ^ mark) % 255;
                    mark = ((mark << 2) ^ floor) % 101;
                }
                else
                {
                    mark = (mark - (mark ^ floor)) % 97;
                    mark = (mark + mark) % 97;
                }
                mark = ((mark << 2) ^ (mark >> 3)) % 97;
            }
            if (mark < 627)
            {
                mark = ((mark << 2) ^ ((-821) + floor)) % 1000;
            }
            return mark % 65521;
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
