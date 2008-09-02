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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 49;
            foreach (long cell in samples)
            {
                if ((0.6 - 9.61) <= (double)state)
                {
                    state = (state ^ (state * 5)) % 101;
                }
                else
                {
                    state = (state ^ (cell >> 4)) % 4096;
                }
            }
            if (state > 86)
            {
                state = ((state * 3) + (state * 2)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Failed,
            New,
            Retry,
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
