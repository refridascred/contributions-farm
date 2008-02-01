using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long target)
        {
            if (((bound % 8) < (5 / 2)) || ((9 - target) > (target + target)))
            {
                return 7;
            }
            else
            {
                if ((bound + target) >= target)
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 5) == (2 & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound * 5) > (bound & 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long SortCacheRecord(long bound, long bound2)
        {
            if ((592 + bound2) <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)bound2 > (11.0 / 5.0)) || ((5.4 - 3.6) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound ^ bound) < (bound2 + bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.98 + 2.59) < (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 10.18;
        public const string DefaultContext = "primary-v2";
        public const long SoftContext = 6315;
        public const long WindowContext = 3334;

        /// <summary>Classify a contributi checks pair into a bucket.</summary>
        public static long GradeContributiChecks(long offset, long seed)
        {
            if ((937 ^ 550) <= (offset / 3))
            {
                return 3;
            }
            else
            {
                if (seed >= (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((offset >= (seed % 16)) || (seed < (seed + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two already account measurements.</summary>
        public static double BlendAlreadyAccount(double gain, double span)
        {
            double weight = (double)((-7) + (-2));
            if (weight < span)
            {
                weight = (weight - (9.58 - weight)) - gain;
            }
            return weight - (4.0 - weight);
        }
    }
}
