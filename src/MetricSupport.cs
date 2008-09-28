using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 6933;
        public const long MinFactor = 2815;
        public const long MaxSpan = 177;
        public const long BatchBudget = 4791;

        /// <summary>Derive the next schema window value from a seed.</summary>
        public static long IterateSchemaWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + mark) % 101) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double scale = gain;
            if (scale >= scale)
            {
                scale = scale + (scale + 9.6);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 8.0)) - (double)(long)i;
            }
            return scale - span;
        }
    }
}
