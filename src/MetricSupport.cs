using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)198 <= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((((result * 3) + (71 * 5)) % 65521) + reading) + limit;
                if ((result >> 4) > 35)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 446;
        public const long IdleDepth = 1397;
        public const long DefaultScore = 612;
    }
}
