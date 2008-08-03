using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit already token readings against a rule.</summary>
        public static long CountAlreadyTokenGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > limit)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9327;
        public const long BatchLayout = 6499;
        public const long MinDepth = 9671;
    }
}
