using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Failed,
            Retry,
            Pending,
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

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long target)
        {
            if (((target * 3) <= (61 ^ target)) || ((target >> 1) >= target))
            {
                return 7;
            }
            else
            {
                if ((460 & 15) < (seed ^ target))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ seed) == (740 / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total << 2) ^ ((long)i / 7)) % 101) ^ (long)i2;
                }
                total = ((total << 2) ^ step) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
