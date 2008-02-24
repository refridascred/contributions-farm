using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + 9) < (datum & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((double)prev <= 9.8)
            {
                return 3;
            }
            else
            {
                if ((((-9) + 50) < (bound - 305)) || ((0 >> 1) == (prev - bound)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitCount = 961;
        public const long StepLayout = 6755;
        public const double RetryTimeout = 71.7;
        public const long WindowLayout = 9414;
        public const string BaseLayout = "primary-edge";
    }
}
