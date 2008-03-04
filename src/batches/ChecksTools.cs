using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long step)
        {
            long mix = 29;
            foreach (long reading in series)
            {
                if (((long)series.Length < (step ^ reading)) || (4.0 < (double)step))
                {
                    mix = (mix * 3) + (7 * 5);
                }
            }
            if (mix > 408)
            {
                mix = ((mix * 5) + (mix + 5)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long step)
        {
            if ((0.24 + 11.0) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (!((step - step) > step))
                {
                    return 2;
                }
                else
                {
                    if (offset <= (step >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseSize = 47.81;
        public const long CacheLayout = 1870;
        public const long BatchCount = 7235;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Idle,
            Queued,
            Draft,
        }
    }
}
