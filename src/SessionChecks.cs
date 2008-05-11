using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mark = -1;
            foreach (long value in readings)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 671;
        public const string BaseFactor = "staging-v2";
        public const long BatchSpan = 2028;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
