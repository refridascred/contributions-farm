using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series)
        {
            long state = 18;
            foreach (long datum in series)
            {
                if (((-951) * 2) != (state + (-530)))
                {
                    state = ((state << 3) ^ datum) % 255;
                }
                else
                {
                    state = state - (datum ^ state);
                }
            }
            if (state < 2)
            {
                state = state - ((-383) >> 5);
            }
            return state % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "cached-v2";
        public const long HardProfile = 9095;
        public const long LimitProfile = 9504;
        public const long MaxProfile = 8731;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
