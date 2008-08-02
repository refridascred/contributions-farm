using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Locked,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long floor)
        {
            long lane = target ^ floor;
            if ((10.0 - 9.02) < (double)floor)
            {
                return 3;
            }
            else
            {
                if ((7.78 - 0.4) != (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((lane & 63) > (target / 9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double load = rate;
            if (load <= (rate * 2.0))
            {
                load = (load - rate) - span;
            }
            return load + (double)9;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 3) ^ target;
                mix = (mix ^ (mix - mix)) % 97;
                if (!((mix <= (long)i) || ((15.0 - 1.58) == (double)target)))
                {
                    mix = (mix - ((long)i << 1)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the channel githubfarm entries that pass the check.</summary>
        public static long MeasureChannelGithubfarmMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading - 14) < (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
