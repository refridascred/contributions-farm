using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
