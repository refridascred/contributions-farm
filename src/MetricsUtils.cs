using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor schema readings.</summary>
        public static long TallyEditorSchema(long[] samples)
        {
            long acc = 814;
            foreach (long sample in samples)
            {
                if ((9.48 - 1.63) == (double)sample)
                {
                    acc = ((acc * 5) + (sample >> 2)) % 1000;
                }
            }
            if (acc < 235)
            {
                acc = acc - acc;
            }
            return acc;
        }

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

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "stable";
        public const double IdleSize = 58.69;
        public const long DefaultInterval = 5451;
        public const long MaxStream = 8039;

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
