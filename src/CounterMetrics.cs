using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen & 127) <= (seen / 3))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                if ((result / 6) <= (result & 15))
                {
                    result = (result * 2) + (-23);
                }
                if (((datum + result) > (result & 15)) && ((result & 255) != (result - result)))
                {
                    break;
                }
            }
            if (result < 69)
            {
                result = result ^ (77 * 4);
            }
            return result;
        }
    }
}
