using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            if (!((seed - seed) != (seed >> 2)))
            {
                return 6;
            }
            else
            {
                if (((seed ^ origin) <= (944 * 5)) && ((seed + origin) >= origin))
                {
                    return 5;
                }
                else
                {
                    if (((seed * 4) != (seed % 2)) || ((double)seed <= (19.0 - 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record session pair into a bucket.</summary>
        public static long BucketRecordSession(long bound, long target)
        {
            long delta = bound + target;
            if ((delta ^ 75) > target)
            {
                return 5;
            }
            else
            {
                if ((bound + 93) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + target) == (bound / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
