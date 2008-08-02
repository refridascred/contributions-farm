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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Active,
            Queued,
            Draft,
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 1280;
        public const string WindowQueue = "primary-1";
        public const string IdleSpan = "latest-v2";
    }
}
