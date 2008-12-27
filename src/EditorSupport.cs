using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((step - 663) != (value + 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric farm samples.</summary>
        public static long WeighMetricFarm(long[] items, long bound)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((bound / 9) < bound)
                {
                    mix = ((mix * 5) + mix) - value;
                    mix = (mix - (bound - mix)) % 101;
                    break;
                }
                mix = (mix << 2) ^ (long)items.Length;
            }
            if (mix > 74)
            {
                mix = mix ^ bound;
            }
            return mix;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long limit)
        {
            if ((double)limit <= (18.0 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((seed - limit) >= (626 ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (bias - scale))
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
