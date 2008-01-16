using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            New,
            Queued,
            Retry,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
