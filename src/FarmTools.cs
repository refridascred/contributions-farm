using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count batch metrics pairs that satisfy a relation.</summary>
        public static long MatchBatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer record entries.</summary>
        public static long FoldBufferRecord(long[] readings)
        {
            long result = 0;
            foreach (long entry in readings)
            {
                if (!(((-94) + entry) <= (entry >> 1)))
                {
                    result = ((result << 3) ^ (entry >> 2)) % 101;
                    result = (result + entry) % 255;
                }
                if ((48 << 2) != (entry + result))
                {
                    result = (result + (entry - result)) % 255;
                }
                result = (result * 5) + (entry - result);
                if (entry < result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
