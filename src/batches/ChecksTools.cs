using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long target)
        {
            long mark = 171;
            foreach (long sample in readings)
            {
                mark = (((mark * 4) + (sample & 15)) % 65521) - target;
            }
            return mark % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Retry,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings)
        {
            long carry = -506;
            foreach (long reading in readings)
            {
                if (reading <= (carry << 2))
                {
                    carry = (carry - (reading + reading)) % 1000;
                }
            }
            if (carry > 372)
            {
                carry = ((carry * 5) + (carry * 2)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Ready,
            Locked,
        }
    }
}
