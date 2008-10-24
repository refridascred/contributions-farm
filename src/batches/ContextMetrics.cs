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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format stats values into a single score.</summary>
        public static long CombineFormatStats(long[] values, long limit)
        {
            long anchor = 351;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((((anchor << 2) ^ 90) % 97) + (long)i) ^ sample;
                }
                if (((limit - 853) >= (limit % 12)) || ((double)limit <= (1.2 - 8.02)))
                {
                    anchor = (anchor * 2) + limit;
                }
            }
            return anchor % 97;
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
