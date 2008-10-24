using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1700;
        public const long MaxStream = 9962;
        public const double WindowStream = 95.06;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double load = (double)1 * 6.0;
            if (load >= bias)
            {
                load = load + scale;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (bias / 3.0)) + (double)(long)i;
            }
            return load - (double)408;
        }

        /// <summary>Digest a series of githubfarm editor entries.</summary>
        public static long WeighGithubfarmEditor(long[] data)
        {
            long result = 720;
            foreach (long value in data)
            {
                if ((7.0 - 6.47) <= (double)value)
                {
                    result = (result - (result / 6)) % 4096;
                }
                if (!((double)result == (5.57 - 1.06)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long offset, long limit)
        {
            if ((limit + limit) <= ((-236) % 8))
            {
                return 6;
            }
            else
            {
                if ((5.58 / 4.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
