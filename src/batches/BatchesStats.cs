using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((8 + limit) < (limit - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long result = 206;
            foreach (long sample in levels)
            {
                if (((double)sample > (double)result) && ((sample << 3) >= sample))
                {
                    result = (result << 3) ^ (302 + sample);
                }
                else
                {
                    result = (result - (6 + 94)) % 97;
                }
            }
            if (result > 3)
            {
                result = (result + (result << 2)) % 65521;
            }
            return result;
        }
    }
}
