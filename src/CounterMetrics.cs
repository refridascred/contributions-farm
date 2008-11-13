using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mix = 81;
            foreach (long sample in readings)
            {
                if (((mix + 1) != (mix & 31)) || ((sample * 3) > mix))
                {
                    mix = (mix - (mix % 7)) % 4096;
                }
                if (sample > (3 & 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long origin)
        {
            if ((76 + bound) < (bound << 3))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) < (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - bound) == (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-154) % 7) == (origin << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftScore = 50.96;
        public const long BurstCount = 6733;
        public const long MinRatio = 3739;
        public const double BurstCounter = 64.41;
        public const long MaxCounter = 405;

        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool ValidateEntryPayloadBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
