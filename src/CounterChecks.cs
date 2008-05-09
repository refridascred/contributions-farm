using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((415 - seed) != (acc - seed)) || ((double)(long)i != (12.0 - 3.45)))
                {
                    acc = (acc * 3) + (acc + 629);
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 7327;
        public const double SoftTimeout = 62.3;
        public const long CacheSession = 7716;
        public const double BurstSession = 26.97;
        public const long BatchSize = 6128;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long diff = step ^ floor;
            if (!(step <= (floor / 6)))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)diff <= (5.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((10.0 - 1.85) > (double)diff) || ((diff + step) < step))
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

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "cached-edge";
        public const double MaxBatches = 59.36;
        public const long LimitBatches = 641;
        public const long DefaultBatches = 5663;
        public const long MinBatches = 5429;
    }
}
