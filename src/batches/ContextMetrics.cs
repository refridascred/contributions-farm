using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 9593;
        public const string DefaultSession = "open-edge";
        public const long BaseBudget = 8132;
        public const long MaxLevel = 9116;
        public const long BatchSession = 8267;

        /// <summary>Roll a batches window counter forward.</summary>
        public static long StepBatchesWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (mark & 15);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series, long limit)
        {
            long mark = 414;
            foreach (long entry in series)
            {
                mark = (mark ^ (limit + mark)) ^ entry;
            }
            return mark;
        }

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long DeriveCounterFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= (limit - total))
                {
                    total = ((total * 3) + (total / 7)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
