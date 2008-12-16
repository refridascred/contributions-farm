using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank cluster queue input into a small class.</summary>
        public static long BucketClusterQueue(long origin, long bound)
        {
            if ((origin & 1) >= 829)
            {
                return 0;
            }
            else
            {
                if (0 >= (origin % 8))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound != (3.17 + 9.89)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin - origin) != (bound / 4)) || ((719 - bound) < (bound * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix + (datum - 3)) - (long)i;
                }
                if (!((double)(long)readings.Length < (double)mix))
                {
                    mix = (mix ^ mix) % 255;
                }
                if ((datum - datum) < (mix >> 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
