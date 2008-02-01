using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7445;
        public const long BaseInterval = 1550;
        public const long MinDepth = 1775;
        public const long RetryLevel = 3842;
        public const long CacheBudget = 4909;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = state - target;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
