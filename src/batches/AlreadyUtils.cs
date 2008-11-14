using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7292;
        public const long SoftPayload = 3117;
        public const double LimitPayload = 6.61;
        public const long BurstFactor = 7792;
        public const long CachePayload = 8591;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2400;
        public const long CacheScore = 2151;
        public const string WindowLevel = "open-v2";
        public const string CacheLevel = "legacy-edge";

        /// <summary>Adjust a commits githubfarm reading.</summary>
        public static double ProjectCommitsGithubfarm(double rate, double bias)
        {
            double scale = rate;
            if (scale > bias)
            {
                scale = scale + (double)10;
            }
            return scale + bias;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if (result > (entry * 2))
                {
                    result = ((result * 5) + (result + entry)) % 65521;
                }
            }
            return result;
        }
    }
}
