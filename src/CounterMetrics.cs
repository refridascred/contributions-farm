using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchInterval = 17.66;
        public const long LimitScore = 9313;
        public const double BatchContributi = 7.02;

        /// <summary>Derive the next schema layout value from a seed.</summary>
        public static long SeriesSchemaLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + ((long)i * 4);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
