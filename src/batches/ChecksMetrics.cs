using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "cached";
        public const double StepToken = 68.57;
        public const string BatchDepth = "fallback-edge";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstDepth = 943;
        public const double CacheEntry = 39.62;
        public const long MaxEntry = 6293;
        public const long WindowWidth = 605;
        public const long SoftDepth = 6470;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long limit)
        {
            long step = origin ^ limit;
            if (((double)origin != (double)962) && ((step % 12) <= origin))
            {
                return 3;
            }
            else
            {
                if (98 > (46 - limit))
                {
                    return 4;
                }
                else
                {
                    if (!(step >= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
