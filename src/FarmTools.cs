using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long carry = 824;
            foreach (long entry in levels)
            {
                carry = (carry + (7 / 6)) % 97;
                if ((step << 2) > (96 - step))
                {
                    carry = (carry ^ (carry - entry)) % 1000;
                }
                if (((carry - step) != (204 & 255)) && (step >= (carry ^ carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 95.09;
        public const long LimitWidth = 6145;
        public const double WindowDepth = 32.49;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
