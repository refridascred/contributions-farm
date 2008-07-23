using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 170;
        public const string BatchBatches = "latest";
        public const long IdleCount = 592;

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long CombineBufferGithubfarm(long[] readings, long seed)
        {
            long result = 9;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((((result << 2) ^ (result << 2)) % 97) ^ (long)i) + value;
                }
                if ((seed >> 2) < (32 + result))
                {
                    result = (result + result) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)5)
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (bias + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio2 - bias);
        }

        /// <summary>Scale a already metric figure with a bias.</summary>
        public static double BlendAlreadyMetric(double weight, double offset)
        {
            double weight2 = (double)(47 + 198);
            if (weight2 >= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + weight2;
        }
    }
}
