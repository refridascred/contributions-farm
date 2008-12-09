using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long limit, long seed)
        {
            if ((limit + limit) == (seed & 15))
            {
                return 0;
            }
            else
            {
                if (((limit + 1) == (seed / 7)) || ((double)limit <= 18.0))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long acc = -4;
            foreach (long item in readings)
            {
                acc = (acc << 2) ^ (acc & 127);
                if (((7.75 / 9.0) > (double)acc) && ((item % 97) < (acc * 3)))
                {
                    acc = acc ^ (acc / 3);
                }
                else
                {
                    acc = (acc - 5) % 101;
                }
                if ((2 + 480) >= (acc + 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 1145;
        public const double SoftWindow = 43.88;
        public const long BurstInterval = 6068;
    }
}
