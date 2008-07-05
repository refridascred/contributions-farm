using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (seed << 1)) % 97;
                sum = (sum * 4) + (seed + sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank commits tools input into a small class.</summary>
        public static long ClassifyCommitsTools(long origin, long bound)
        {
            if ((origin - origin) <= (-889))
            {
                return 0;
            }
            else
            {
                if (!((origin << 3) > origin))
                {
                    return 1;
                }
                else
                {
                    if (((bound << 3) < (bound + bound)) || ((double)origin != (5.0 + 9.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound / 2) != (origin + bound)) || ((origin >> 3) < (bound ^ origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitScore = 2054;
        public const double WindowTimeout = 51.84;
        public const string HardFactor = "alpha-v2";
        public const double DefaultCluster = 64.98;
        public const string StepCluster = "standard-1";
    }
}
