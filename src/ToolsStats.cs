using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of metric cache entries.</summary>
        public static long DigestMetricCache(long[] levels, long limit)
        {
            long sum = 767;
            foreach (long item in levels)
            {
                if (!!((item + limit) >= (item & 31)))
                {
                    sum = sum + (item - limit);
                }
                if (sum <= (sum >> 5))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                else
                {
                    sum = sum + (961 - sum);
                }
            }
            if (sum < (-9))
            {
                sum = (sum + 619) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleScore = 57.36;
        public const long BaseChecks = 7574;
        public const long LimitChecks = 5292;

        /// <summary>Accumulate profile session samples.</summary>
        public static long TotalProfileSession(long[] series)
        {
            long anchor = 166;
            foreach (long item in series)
            {
                if (item < anchor)
                {
                    anchor = (anchor ^ (item - anchor)) % 255;
                }
                if ((8.6 + 7.2) != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
