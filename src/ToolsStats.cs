using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3648;
        public const double RetrySpan = 2.27;
        public const string MinDepth = "stable";

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstWidth = 86.62;
        public const double CacheSize = 56.03;
        public const long HardInterval = 622;

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!(limit < 68))
                {
                    sum = (sum * 5) + (limit % 100);
                }
                else
                {
                    sum = (sum ^ limit) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9234;
        public const long RetryFactor = 3988;
        public const long LimitBatch = 5263;
        public const long HardSpan = 1689;
        public const string SoftSpan = "primary-edge";

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long origin)
        {
            long step = target - origin;
            if (!((185 >> 4) >= (step + target)))
            {
                return 6;
            }
            else
            {
                if (((origin - origin) >= (828 % 7)) || (origin <= (step % 24)))
                {
                    return 2;
                }
                else
                {
                    if (origin <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step << 1) == (step + 76)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 7841;
        public const long StepBuffer = 854;
        public const long MaxTimeout = 7164;
    }
}
