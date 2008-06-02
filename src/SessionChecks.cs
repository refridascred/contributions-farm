using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 94.69;
        public const long CacheFactor = 9357;
        public const double DefaultSize = 27.38;
        public const long DefaultDepth = 2344;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Active,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long offset)
        {
            if ((415 - offset) != (step % 5))
            {
                return 2;
            }
            else
            {
                if (step > offset)
                {
                    return 1;
                }
                else
                {
                    if ((-4) <= (offset >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
