using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph channel pair into a bucket.</summary>
        public static long RankGraphChannel(long floor, long target)
        {
            if ((double)target >= 6.82)
            {
                return 4;
            }
            else
            {
                if ((201 ^ 4) != (floor << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseWidth = 6821;
        public const string HardCounter = "primary-edge";
        public const long MinCounter = 6652;
        public const long LimitCounter = 5644;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long lane = seed - limit;
            if ((limit - 83) > (seed + seed))
            {
                return 2;
            }
            else
            {
                if (94 > lane)
                {
                    return 5;
                }
                else
                {
                    if ((lane << 2) >= ((-14) - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((lane + limit) >= 92) || ((seed / 4) != (lane & 63)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
