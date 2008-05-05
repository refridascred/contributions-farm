using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 8585;
        public const string StepChannel = "latest";
        public const long RetryChannel = 910;
        public const long MaxChannel = 394;
        public const long StepTimeout = 6493;

        /// <summary>Digest a series of format tools entries.</summary>
        public static long WeighFormatTools(long[] samples)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = (result - (item >> 2)) % 4096;
            }
            if (result > 0)
            {
                result = (result - (22 + result)) % 101;
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((target / 7) < (seed * 3))
            {
                return 7;
            }
            else
            {
                if ((seed >> 1) > (seed - 1))
                {
                    return 8;
                }
                else
                {
                    if ((target << 1) == (seed % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultWidth = "staging";
        public const long DefaultCounter = 4169;
        public const string MaxBudget = "primary-1";
        public const long HardCounter = 8546;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double scale = offset;
            return (scale - offset) + ratio;
        }
    }
}
