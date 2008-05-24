using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long bound, long floor)
        {
            long step = bound + floor;
            if (((6.5 / 7.0) >= (double)floor) || ((floor + bound) > (floor % 7)))
            {
                return 5;
            }
            else
            {
                if (!((step ^ 4) == (step << 1)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
