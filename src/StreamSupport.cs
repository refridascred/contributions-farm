using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total - (10 + origin)) % 4096;
                if ((origin / 4) != (long)i)
                {
                    total = (total - origin) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "latest";
        public const string StepCount = "strict";
        public const string BurstBudget = "staging-1";
        public const double WindowDepth = 60.0;
        public const long MinInterval = 5618;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
