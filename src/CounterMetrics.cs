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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum ^ sum) % 1000;
                sum = sum ^ ((long)i + (long)i);
                sum = (sum ^ (sum ^ origin)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
