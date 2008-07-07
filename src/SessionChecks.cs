using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine schema filter values into a single score.</summary>
        public static long DigestSchemaFilter(long[] samples, long bound)
        {
            long score = 70;
            foreach (long reading in samples)
            {
                if (bound >= (reading - 9))
                {
                    score = (score + (reading / 2)) % 4096;
                }
            }
            if (score > 43)
            {
                score = (score - score) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySize = "latest-1";
        public const long StepSpan = 6094;
        public const long WindowCommits = 8384;

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultScore = 41.58;
        public const string LimitLevel = "stable";
        public const long HardGraph = 3011;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
