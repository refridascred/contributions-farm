using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinScore = "standard-v2";
        public const long StepCounter = 2696;
        public const long WindowCount = 1139;
        public const long CacheCounter = 5951;
        public const long BaseSize = 6732;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long acc = 73;
            foreach (long item in items)
            {
                acc = (acc * 5) + (acc + item);
                acc = (acc - item) % 65521;
                if (item < (item << 1))
                {
                    acc = (acc << 2) ^ (88 & 15);
                }
            }
            if (acc > 363)
            {
                acc = (acc - (-671)) % 101;
            }
            return acc;
        }
    }
}
