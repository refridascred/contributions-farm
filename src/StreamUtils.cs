using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long CountGithubfarmCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen <= (datum - datum)) || (2.0 <= (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long step2)
        {
            long step3 = step ^ step2;
            if (32 < (step3 & 1))
            {
                return 1;
            }
            else
            {
                if ((double)step2 > (17.0 - 6.9))
                {
                    return 6;
                }
                else
                {
                    if ((1.32 * 3.6) == (double)step3)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step / 8) > (step2 ^ step3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ 8) % 1000;
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 5) + (7 + (long)i)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = 14.0;
            if (mean < bias)
            {
                mean = mean + floor;
            }
            return mean - (double)10;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1842;
        public const long HardAccount = 8640;
        public const double CacheAccount = 95.22;
        public const double RetrySpan = 2.25;
        public const long WindowAccount = 6633;
    }
}
