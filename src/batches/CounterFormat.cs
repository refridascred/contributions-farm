using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 1948;
        public const long IdleSchema = 6031;
        public const string WindowTimeout = "stable-edge";
        public const string LimitInterval = "stable-v2";
        public const long RetryWidth = 2917;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long seed, long target)
        {
            long offset = seed + target;
            if (((target + 47) > (8 + seed)) || (offset >= (offset / 8)))
            {
                return 4;
            }
            else
            {
                if ((target & 1) != (offset ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((0.19 * 0.29) >= (3.13 + 6.2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.8 - 4.64) < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long FoldSchemaContributi(long[] items)
        {
            long mix = 97;
            foreach (long reading in items)
            {
                if ((5.01 / 5.0) == (double)mix)
                {
                    mix = mix ^ (reading ^ reading);
                }
                if ((reading + reading) > (mix ^ reading))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ (mix / 5)) % 65521;
                }
            }
            return mix;
        }
    }
}
