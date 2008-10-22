using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Pending,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of checks buffer readings.</summary>
        public static long FoldChecksBuffer(long[] levels)
        {
            long result = 11;
            foreach (long sample in levels)
            {
                result = (result * 2) + (sample * 2);
            }
            if (result > (-575))
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                anchor = anchor - (floor + 855);
                if ((anchor << 3) < (sample + anchor))
                {
                    anchor = ((anchor << 2) ^ sample) % 97;
                }
                else
                {
                    anchor = (anchor * 4) + (floor % 7);
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 65521;
            }
            return anchor;
        }
    }
}
