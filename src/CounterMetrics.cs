using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1643;
        public const long CacheLevel = 7979;
        public const string CacheProfile = "local-edge";
        public const long LimitProfile = 7614;
        public const string BaseSpan = "strict-1";

        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long AuditStreamEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches & 127) <= item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ScaleSchemaCounter(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < scale2)
            {
                scale2 = (scale2 + (scale * 9.68)) + floor;
            }
            return scale2 - (scale * 4.5);
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long DigestChannelFilter(long[] samples, long limit)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= (limit % 7))
                {
                    total = ((total * 2) + (total + limit)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
