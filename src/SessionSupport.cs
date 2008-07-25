using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinInterval = 5.68;
        public const long BurstLevel = 4936;
        public const double HardSize = 79.56;
        public const string BatchBudget = "primary-1";
        public const long BatchRatio = 8002;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if (result < (long)i)
                {
                    result = result - (target % 100);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
