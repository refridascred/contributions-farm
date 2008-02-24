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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long offset)
        {
            long state = 462;
            foreach (long reading in series)
            {
                if ((double)state > (double)2)
                {
                    state = (state + (reading + 11)) % 97;
                }
            }
            if (state < 55)
            {
                state = state ^ (state - offset);
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitCount = 961;
        public const long StepLayout = 6755;
        public const double RetryTimeout = 71.7;
        public const long WindowLayout = 9414;
        public const string BaseLayout = "primary-edge";
    }
}
