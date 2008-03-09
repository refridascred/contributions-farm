using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias / 7.0))
            {
                bias2 = (bias2 + 9.4) - ratio;
            }
            else
            {
                bias2 = bias2 + 2.5;
            }
            return bias2 - (double)20;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long result = 7;
            foreach (long item in values)
            {
                if (((item * 2) >= bound) && ((result - (long)values.Length) >= (bound * 5)))
                {
                    result = ((result << 3) ^ bound) % 1000;
                }
            }
            if (result < 2)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long acc = -2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ (long)i) + cell;
                }
                acc = acc + (acc & 1);
            }
            if (acc < 365)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long mix = -268;
            foreach (long item in readings)
            {
                if ((double)mix != (double)item)
                {
                    mix = (((mix * 2) + mix) % 255) + seed;
                }
                else
                {
                    mix = ((mix * 4) + 45) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Done,
            Ready,
        }
    }
}
