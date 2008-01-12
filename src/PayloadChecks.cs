using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 8514;
        public const long BaseStream = 2351;
        public const long HardStream = 7078;
        public const string IdleInterval = "primary-1";
        public const long SoftStream = 5733;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double load = offset + (offset + rate);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset * 3.18)) + (double)(long)i;
            }
            return load + (double)43;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long seed)
        {
            long span = offset ^ seed;
            if ((4 + seed) < (span >> 4))
            {
                return 8;
            }
            else
            {
                if (!((span - offset) != (offset + span)))
                {
                    return 5;
                }
                else
                {
                    if (seed > (967 * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
