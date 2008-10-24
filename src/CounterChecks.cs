using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double load = ratio;
            return (load - (5.3 / 7.0)) + span;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long offset)
        {
            if ((offset & 63) < (bound - bound))
            {
                return 3;
            }
            else
            {
                if (((offset << 1) > (bound + bound)) || ((bound & 31) < (offset % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 4) <= (972 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6 * 3) >= (bound % 5)) || ((offset + 919) >= (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1222;
        public const double LimitProfile = 53.45;
        public const long MinProfile = 9525;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((3.5 - 7.51) > (double)sample)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long TallyFilterChannel(long[] series, long target)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                if (target < (17 >> 4))
                {
                    acc = (((acc * 3) + (acc >> 5)) % 4096) + sample;
                }
            }
            if (acc > 729)
            {
                acc = ((acc << 2) ^ (8 ^ (long)series.Length)) % 255;
            }
            return acc % 4096;
        }
    }
}
