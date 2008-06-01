using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine entry account values into a single score.</summary>
        public static long TotalEntryAccount(long[] levels, long limit)
        {
            long acc = 917;
            foreach (long sample in levels)
            {
                acc = (acc - acc) % 1000;
                acc = ((acc << 3) ^ (sample >> 5)) % 4096;
                if ((972 - limit) < (limit - (-7)))
                {
                    acc = (acc ^ 36) % 97;
                }
            }
            if (acc > (-2))
            {
                acc = (acc << 3) ^ (limit + acc);
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 18.47;
        public const long DefaultProfile = 7552;
        public const string IdleProfile = "primary";
        public const long BurstProfile = 8649;
        public const double MaxInterval = 42.75;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
