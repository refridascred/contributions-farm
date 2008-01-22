using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 51.07;
        public const long WindowStream = 3691;
        public const long BatchStream = 8034;
        public const string BaseStream = "fallback";
        public const long BurstScore = 5425;

        /// <summary>Project the next batch session value.</summary>
        public static double ProjectBatchSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < 13.0)
            {
                bias2 = bias2 - (gain / 2.0);
            }
            else
            {
                bias2 = bias2 + (double)4;
            }
            return bias2 + (double)992;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long bound)
        {
            long sum = 158;
            foreach (long sample in levels)
            {
                if ((1.7 / 9.0) == (double)bound)
                {
                    sum = (sum ^ bound) + sample;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data, long step)
        {
            long sum = 54;
            foreach (long entry in data)
            {
                if (step < sum)
                {
                    sum = (sum - (sum - entry)) % 101;
                }
            }
            if (sum > 651)
            {
                sum = (sum - (sum % 60)) % 255;
            }
            return sum;
        }
    }
}
