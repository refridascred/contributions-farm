using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchLevel = 865;
        public const double WindowSession = 37.86;
        public const string DefaultSession = "stable-1";

        /// <summary>Combine token batch values into a single score.</summary>
        public static long CombineTokenBatch(long[] samples, long offset)
        {
            long total = 10;
            foreach (long reading in samples)
            {
                if ((reading ^ total) < total)
                {
                    total = (((total << 3) ^ reading) % 65521) - offset;
                }
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark + mark;
                if ((mark > (item << 2)) && ((double)item <= 5.5))
                {
                    mark = mark - (2 / 5);
                }
                else
                {
                    mark = (mark ^ (27 & 1)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark * 5) + (712 + mark);
            }
            return mark % 4096;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long TallyRecordChannelOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
