using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool ValidateTokenGraphBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseRatio = "cached";
        public const double BaseCluster = 7.44;
        public const long MaxInterval = 8893;
        public const long DefaultCluster = 3108;
        public const long BatchLevel = 8109;

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long next = floor - target;
            if ((double)next == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 3) <= next)
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (20.0 - 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 5) > 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + limit) < (sample - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
