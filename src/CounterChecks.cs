using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((3 / 3) == (seed2 ^ seed2))
            {
                return 3;
            }
            else
            {
                if (((1.92 * 5.94) > (double)seed2) && ((6 + slot) <= (4 >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + slot) < (slot % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double drift = weight;
            if (drift <= span)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (weight / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)417) - (double)(long)i;
            }
            return drift - 0.79;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + 5) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
