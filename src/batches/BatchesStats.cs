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

        /// <summary>Iterate the githubfarm format series from a seed.</summary>
        public static long RollGithubfarmFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (seed % 2)) % 4096;
                total = (total + ((long)i % 97)) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitCount = 961;
        public const long StepLayout = 6755;
        public const double RetryTimeout = 71.7;
        public const long WindowLayout = 9414;
        public const string BaseLayout = "primary-edge";
    }
}
