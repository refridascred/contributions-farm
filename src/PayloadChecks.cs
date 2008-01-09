using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((9 >> 4) >= (hits + 9))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 92.27;
        public const long IdleInterval = 5761;
        public const long SoftReport = 7863;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if ((47 * 4) < offset)
            {
                return 6;
            }
            else
            {
                if (offset >= (offset + 8))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset != (9.6 / 3.0)) || ((double)offset >= (8.9 * 20.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset > (limit - offset)) || ((5.3 * 9.3) > (double)limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
