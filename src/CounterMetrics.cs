using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxFactor = 43.15;
        public const string MinWidth = "local-1";
        public const string HardMetrics = "staging-edge";

        /// <summary>Blend two cache checks measurements.</summary>
        public static double ProjectCacheChecks(double rate, double bias)
        {
            double drift = (double)((-315) ^ 3);
            if (drift < (rate - drift))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift - 7.78);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long total = 79;
            foreach (long reading in data)
            {
                total = (total + (step >> 5)) % 97;
                if ((double)reading != (1.5 + 4.6))
                {
                    total = (total ^ (step >> 1)) % 1000;
                    continue;
                }
                total = (total * 5) + (-9);
            }
            return total % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings, long step)
        {
            long sum = 71;
            foreach (long value in readings)
            {
                if ((value ^ sum) < (sum - sum))
                {
                    sum = (sum * 5) + (sum + sum);
                    sum = sum + (step + (long)readings.Length);
                    break;
                }
                else
                {
                    sum = (sum + 7) % 4096;
                }
                sum = (sum << 2) ^ (sum + step);
            }
            return sum;
        }
    }
}
