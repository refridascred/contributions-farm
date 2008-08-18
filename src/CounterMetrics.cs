using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double weight, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load - load) - weight;
            }
            else
            {
                load = load - bias;
            }
            return load + (5.6 + load);
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double rate = scale;
            if (rate >= (rate * 3.95))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)141) + (double)(long)i;
            }
            return rate - (rate + span);
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            if ((double)seed < (3.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) > (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if (((bound + 134) >= seed) || ((seed - 0) > (seed + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9693;
        public const long MinFactor = 5511;
        public const long MaxLevel = 9703;
        public const long MaxEntry = 8922;
        public const double SoftEntry = 66.05;
    }
}
