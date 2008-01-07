using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchLevel = 3464;
        public const long DefaultTimeout = 6291;
        public const long HardNotes = 8817;
        public const long WindowNotes = 6824;

        /// <summary>Match up githubfarm payload samples.</summary>
        public static long PairGithubfarmPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
