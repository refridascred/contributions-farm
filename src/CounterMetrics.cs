using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((2.46 - 8.5) < (double)result))
                {
                    result = result ^ limit;
                }
                if ((14.0 + 2.0) == (double)limit)
                {
                    result = ((result * 4) + (limit + limit)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleFactor = "standard";
        public const long BaseContext = 8815;
        public const long DefaultDepth = 7150;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
