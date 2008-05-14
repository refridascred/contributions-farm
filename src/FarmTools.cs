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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long result = 6;
            foreach (long entry in readings)
            {
                if (((result - result) > (result / 4)) || (6 <= (result + entry)))
                {
                    result = ((result << 3) ^ entry) % 65521;
                    result = (result - (long)readings.Length) % 101;
                }
                result = result ^ (result << 3);
            }
            if (result < (-830))
            {
                result = ((result * 3) + (result * 3)) % 65521;
            }
            return result;
        }
    }
}
