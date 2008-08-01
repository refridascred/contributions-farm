using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            New,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSize = 6449;
        public const long BaseSize = 6747;
        public const long SoftInterval = 8680;
        public const double LimitFactor = 18.66;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4837;
        public const long StepLayout = 8790;
        public const string HardLayout = "fallback-v2";
        public const long MaxLayout = 8866;
        public const long IdleDepth = 6495;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                bool ok = ((target ^ mix) == (mix << 2)) && (8.1 > (double)mix);
                mix = (mix + (target & 15)) % 1000;
                if (ok || ((target + target) > mix))
                {
                    ok = ((3.12 * 11.0) > (double)(long)i) && ((target ^ (long)i) != (mix + (long)i));
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first route already entry that matches the target.</summary>
        public static long SeekRouteAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
