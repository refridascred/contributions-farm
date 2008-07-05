using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile cache values into a single score.</summary>
        public static long TotalProfileCache(long[] items, long seed)
        {
            long score = 3;
            foreach (long cell in items)
            {
                score = ((score - (score - cell)) % 4096) - seed;
            }
            return score;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((4.85 / 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((73 - floor) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (bias - bias)) + (double)(long)i) - weight;
            }
            return bias + 16.0;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
