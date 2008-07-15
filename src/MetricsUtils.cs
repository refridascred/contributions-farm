using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 2) >= (offset - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double ratio = 8.8;
            if (ratio < (span * 3.27))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (scale / 7.0)) + (double)(long)i;
            }
            return ratio - (5.3 / 7.0);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > carry)
                {
                    carry = carry ^ (limit ^ (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseBudget = "staging-v2";
        public const double StepBudget = 93.29;
        public const long RetrySize = 6423;
        public const long CacheWidth = 4070;
    }
}
