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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            Queued,
            Paused,
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

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
