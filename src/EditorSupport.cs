using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = (floor / 9.0) * 14.0;
            if (drift >= drift)
            {
                drift = (drift - 5.2) + scale;
            }
            else
            {
                drift = drift + (floor * 20.0);
            }
            return drift - floor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 2) <= (long)items.Length)
                {
                    seen = ((seen + 2) ^ entry) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if (!(item <= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 101;
                }
            }
            if (mix > 333)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 4663;
        public const long LimitBuffer = 4022;
        public const double BaseBuffer = 98.85;
        public const double SoftBuffer = 80.89;
        public const double BaseRatio = 34.65;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6675;
        public const long LimitBudget = 1137;
        public const double WindowCounter = 31.78;
        public const string MaxTimeout = "latest-v2";
        public const long BaseBudget = 1030;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate - (double)78) - ratio;
            }
            else
            {
                rate = rate - bias;
            }
            return rate - bias;
        }
    }
}
