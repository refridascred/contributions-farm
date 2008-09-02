using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheWidth = 6519;
        public const double MinAlready = 89.37;
        public const long IdleRatio = 9464;
        public const double BurstAlready = 19.96;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = -50;
            foreach (long item in samples)
            {
                if ((result <= (result + item)) && ((8 - item) < (item + result)))
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            return result;
        }
    }
}
