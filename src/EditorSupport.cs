using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long floor)
        {
            if ((seed - floor) <= (floor * 2))
            {
                return 1;
            }
            else
            {
                if (!(773 < (seed - (-1))))
                {
                    return 6;
                }
                else
                {
                    return 7;
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

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
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
