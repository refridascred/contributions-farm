using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "primary-1";
        public const double StepScore = 92.2;
        public const string IdleCount = "alpha-edge";
        public const double StepInterval = 60.3;
        public const double BatchRatio = 38.19;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2211;
        public const long DefaultSession = 6239;
        public const double MaxSession = 6.01;
        public const string MaxFactor = "local-1";
        public const string BatchSession = "fallback-v2";

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + tally) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
