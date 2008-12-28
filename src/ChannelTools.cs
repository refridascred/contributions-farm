using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long offset)
        {
            long total = -790;
            foreach (long sample in items)
            {
                if (((1.1 + 14.0) < (double)offset) || (total <= (offset << 1)))
                {
                    total = ((total - (offset + offset)) % 1000) ^ sample;
                }
            }
            if (total < 675)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
