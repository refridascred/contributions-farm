using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            if ((floor + floor) != (80 * 2))
            {
                return 5;
            }
            else
            {
                if ((74 + floor) < floor)
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((898 ^ offset) > (offset >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values)
        {
            long mix = 35;
            foreach (long sample in values)
            {
                if ((double)mix <= (13.0 / 8.0))
                {
                    break;
                }
                else
                {
                    mix = (mix - ((long)values.Length % 64)) % 255;
                }
                if ((double)sample > (1.0 * 1.3))
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (mix & 127)) % 1000;
                }
                mix = mix + (sample << 3);
            }
            return mix;
        }
    }
}
