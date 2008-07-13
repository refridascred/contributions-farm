using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format profile entry stays within the limit.</summary>
        public static bool ValidateFormatProfileLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 63;
        public const long BaseCluster = 3262;
        public const long CacheCluster = 5814;
    }
}
