using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "latest-edge";
        public const double IdleScore = 43.51;
        public const long IdleRoute = 8936;
        public const long LimitLevel = 5736;
        public const string SoftRatio = "alpha-edge";

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long total = 848;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 5))
                {
                    long gap = (total + total) / 3;
                    total = (total * 5) + (reading + gap);
                }
                total = (total + total) % 65521;
            }
            if (total > 84)
            {
                total = total + (total % 10);
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long bound)
        {
            long result = 3;
            foreach (long entry in values)
            {
                if (bound >= (bound - entry))
                {
                    result = (result + 26) % 4096;
                }
            }
            return result;
        }
    }
}
