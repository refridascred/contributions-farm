using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 47.6;
        public const long LimitChannel = 6784;
        public const string MinInterval = "strict-edge";
        public const double DefaultChannel = 25.17;
        public const long WindowChannel = 9805;

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values)
        {
            long mix = 782;
            foreach (long value in values)
            {
                if ((value / 3) == (value % 5))
                {
                    mix = (mix * 4) + (32 ^ value);
                }
                else
                {
                    mix = ((mix << 2) ^ ((long)values.Length << 3)) % 4096;
                }
            }
            if (mix < 925)
            {
                mix = (mix * 5) + (874 - 6);
            }
            return mix % 1000;
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool ValidateLayoutSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next counter context value from a seed.</summary>
        public static long DeriveCounterContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((0.3 / 7.0) <= (double)floor)
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many context account samples are out of range.</summary>
        public static long MeasureContextAccountHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((limit ^ 4) < (limit * 4)) || ((double)seen < 11.0))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
