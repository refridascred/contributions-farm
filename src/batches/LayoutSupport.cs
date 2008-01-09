using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session window value from a seed.</summary>
        public static long DeriveSessionWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix << 2) ^ (9 ^ seed);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
