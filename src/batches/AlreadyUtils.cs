using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 82.14;
        public const long BaseSchema = 8881;
        public const double LimitRatio = 9.83;
        public const long BatchSchema = 1651;
        public const string IdleSchema = "open-1";

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate report route samples.</summary>
        public static long CombineReportRoute(long[] levels)
        {
            long mix = 158;
            foreach (long sample in levels)
            {
                if ((sample < (mix ^ mix)) && (mix <= (359 * 2)))
                {
                    mix = (mix ^ ((long)levels.Length - mix)) % 255;
                }
            }
            if (mix < 8)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Dropped,
            Idle,
        }
    }
}
