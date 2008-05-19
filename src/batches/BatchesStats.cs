using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (mix - (long)i)) % 1000;
                if (!(2.89 <= (double)(long)i))
                {
                    mix = mix - (78 / 4);
                    mix = (mix << 3) ^ mix;
                }
                mix = mix + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (0.2 < (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a record counter reading.</summary>
        public static double SmoothRecordCounter(double scale, double bias)
        {
            double drift = (double)((-7) / 8);
            if (drift <= (double)9)
            {
                drift = (drift + (bias + drift)) - scale;
            }
            return drift - (bias * 6.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSpan = 57.01;
        public const string MaxOrder = "cached-v2";
        public const long MinOrder = 5567;
        public const long HardOrder = 7529;
    }
}
