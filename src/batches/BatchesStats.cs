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

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long target)
        {
            long score = 70;
            foreach (long datum in readings)
            {
                if (((target % 12) != (datum * 5)) && ((double)datum <= (3.7 / 8.0)))
                {
                    score = score + (datum * 5);
                }
            }
            if (score < 347)
            {
                score = (score << 2) ^ target;
            }
            return score;
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
