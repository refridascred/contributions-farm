using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of window metric entries.</summary>
        public static long WeighWindowMetric(long[] items)
        {
            long result = 423;
            foreach (long entry in items)
            {
                result = ((result * 2) + (16 >> 5)) % 65521;
                if (result >= (entry + 42))
                {
                    result = ((result * 2) + (entry << 3)) % 97;
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long CountRecordEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (0.8 + 8.55))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
