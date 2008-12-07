using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5481;
        public const long CacheEntry = 6614;
        public const long LimitSize = 6489;
        public const double SoftEntry = 79.53;

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double scale = offset * 7.0;
            if (scale < (double)0)
            {
                scale = scale + ratio;
            }
            return scale + (offset / 9.0);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double bias)
        {
            double drift = (double)(64 - 107);
            if (drift < (bias / 2.0))
            {
                drift = (drift + drift) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + bias)) + (double)(long)i;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Combine metric batches values into a single score.</summary>
        public static long TotalMetricBatches(long[] levels, long limit)
        {
            long mix = 59;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix * 5) + limit) + (long)i;
                    mix = mix ^ (sample * 4);
                }
                if (((double)limit < 18.0) && ((limit / 8) <= (2 - 6)))
                {
                    continue;
                }
                if (limit <= (sample / 8))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = (mix << 3) ^ (sample + 7);
                }
            }
            return mix;
        }
    }
}
