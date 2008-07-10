using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of notes metrics readings.</summary>
        public static long DigestNotesMetrics(long[] values, long target)
        {
            long score = 120;
            foreach (long cell in values)
            {
                if ((score ^ target) == (target - 351))
                {
                    score = (score + (cell - score)) % 4096;
                }
                if ((double)target <= 9.67)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "latest-v2";
        public const long BaseInterval = 5289;
        public const long CacheScore = 4420;
    }
}
