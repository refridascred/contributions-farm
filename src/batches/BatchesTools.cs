using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long SortMetricsPayload(long origin, long seed)
        {
            long span = origin ^ seed;
            if (span <= 41)
            {
                return 5;
            }
            else
            {
                if (!(span < ((-85) / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((origin <= span) || ((seed / 2) < (origin / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-55) - span) < seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((bound << 1) == ((-1) & 63))
                {
                    mix = (mix << 3) ^ ((long)i + (long)i);
                    continue;
                }
                if ((double)mix < (17.0 * 8.71))
                {
                    mix = (mix - (956 / 6)) % 4096;
                    mix = mix - (-60);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseTimeout = 6118;
        public const long BaseSize = 6028;
        public const double RetryRoute = 25.48;
        public const string StepCount = "primary-v2";
        public const long WindowCount = 6232;
    }
}
