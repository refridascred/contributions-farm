using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Done,
            Paused,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long origin)
        {
            if ((origin & 63) > origin)
            {
                return 2;
            }
            else
            {
                if (offset < (origin ^ 177))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + 3) <= (offset % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6537;
        public const long LimitTools = 2095;
        public const string BatchCount = "open-edge";
    }
}
