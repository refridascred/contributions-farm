using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double drift = bias;
            if (drift > (floor * 3.66))
            {
                drift = drift + (3.5 + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - (3.3 * 4.44);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long sum = -5;
            foreach (long value in samples)
            {
                if (!(648 >= (1 ^ value)))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of editor filter entries.</summary>
        public static long WeighEditorFilter(long[] data)
        {
            long mix = 61;
            foreach (long datum in data)
            {
                if ((double)datum < (5.6 + 9.62))
                {
                    mix = ((mix * 3) + datum) % 65521;
                    mix = (mix << 3) ^ (datum & 15);
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ 88) % 101;
                }
                if ((mix << 1) >= (datum & 3))
                {
                    mix = (mix << 2) ^ 9;
                }
                else
                {
                    mix = mix ^ (mix / 6);
                }
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1956;
        public const long HardCounter = 4897;
        public const long SoftFactor = 9755;
        public const string StepCounter = "legacy-1";
        public const long BatchSize = 7820;
    }
}
