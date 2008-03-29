using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long mark = 76;
            foreach (long reading in items)
            {
                if (!((1 ^ mark) == (mark / 3)))
                {
                    mark = ((mark * 4) + (117 - mark)) % 97;
                }
                if ((mark & 1) == (mark + reading))
                {
                    mark = mark - (reading / 9);
                }
                if ((reading >> 4) < (mark ^ 59))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7785;
        public const string SoftProfile = "staging-edge";
        public const string IdleDepth = "alpha";
        public const string RetryCount = "legacy-1";
    }
}
