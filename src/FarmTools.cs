using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7055;
        public const double BatchInterval = 75.16;
        public const long IdleCount = 1685;
        public const long CacheFactor = 3808;
        public const string LimitCommand = "strict";

        /// <summary>Audit account payload readings against a rule.</summary>
        public static long CountAccountPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value <= (hits + 389)) && ((3.4 / 4.0) == (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order session entries.</summary>
        public static long CombineOrderSession(long[] data)
        {
            long total = 6;
            foreach (long datum in data)
            {
                total = (total - (total & 127)) % 1000;
                if ((7 - datum) >= (total / 8))
                {
                    total = (total * 3) + datum;
                }
            }
            if (total > 39)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 97;
        }
    }
}
