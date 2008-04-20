using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double ratio = 4.9 - (double)3;
            if (ratio <= floor)
            {
                ratio = ratio + bias;
            }
            return ratio - floor;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Locked,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long carry = -90;
            foreach (long cell in values)
            {
                if (2.27 < (double)cell)
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 4096;
                }
                else
                {
                    carry = (carry - (origin ^ cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
