using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long target)
        {
            long carry = 696;
            foreach (long entry in series)
            {
                carry = carry ^ entry;
                if ((target + carry) >= target)
                {
                    carry = (carry - ((long)series.Length << 2)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
