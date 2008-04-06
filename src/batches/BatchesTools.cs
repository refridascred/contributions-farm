using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BaseSpan = 6996;
        public const long RetryTimeout = 8460;
        public const long LimitLevel = 212;
        public const double BatchDepth = 25.62;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ (result + step)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
