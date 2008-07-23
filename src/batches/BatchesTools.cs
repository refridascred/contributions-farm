using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long score = 1;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (score + (score ^ datum)) ^ (long)i;
                }
                score = score + (score % 7);
            }
            if (score < 23)
            {
                score = score - (score - score);
            }
            return score % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowSize = "latest-v2";
        public const long RetryQueue = 1748;
        public const double LimitQueue = 60.48;
        public const string CacheQueue = "cached-v2";
        public const long SoftQueue = 6578;
    }
}
