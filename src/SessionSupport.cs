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

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
