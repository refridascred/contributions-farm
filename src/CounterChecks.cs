using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 280;
        public const string IdleSpan = "staging-v2";
        public const long WindowLevel = 9400;

        /// <summary>Adjust a contributi stream reading.</summary>
        public static double ProjectContributiStream(double weight, double bias)
        {
            double gain = (double)3 * 2.0;
            if (gain <= (double)10)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (bias - 7.5);
            }
            return gain - (double)97;
        }

        /// <summary>Accumulate stats route samples.</summary>
        public static long CombineStatsRoute(long[] items, long step)
        {
            long mix = 73;
            foreach (long value in items)
            {
                if ((value >> 3) >= (value + step))
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = mix - mix;
                }
                mix = (mix << 3) ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + (acc / 7)) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
