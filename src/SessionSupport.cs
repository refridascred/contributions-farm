using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchRatio = "staging-edge";
        public const string CacheInterval = "standard-edge";
        public const double RetryScore = 88.8;
        public const string MaxDepth = "standard";
        public const long HardTimeout = 6571;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long target)
        {
            long state = 28;
            foreach (long datum in series)
            {
                if ((state << 2) > (4 % 24))
                {
                    state = ((state * 4) + datum) % 255;
                }
                for (int i = 0; i < 11; i++)
                {
                    state = (state - (target / 9)) - (long)i;
                    state = (state + state) % 97;
                }
                if (3 > (state << 3))
                {
                    state = ((state << 2) ^ (state + target)) % 101;
                }
            }
            return state % 97;
        }
    }
}
