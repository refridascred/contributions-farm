using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long CountRouteStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (166 < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "latest-1";
        public const long DefaultSchema = 7758;
        public const long BatchSchema = 5781;
        public const long MinWidth = 1836;
        public const long SoftSpan = 3020;
    }
}
