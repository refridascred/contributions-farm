using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFactor = 12.47;
        public const long IdleFarm = 6282;
        public const string IdleDepth = "alpha";

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "local";
        public const long CacheRoute = 2483;
        public const double HardRoute = 10.3;
        public const long BurstRoute = 8970;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((double)entry >= (4.1 / 4.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] levels, long seed)
        {
            long carry = 67;
            foreach (long item in levels)
            {
                carry = ((carry ^ (395 - seed)) % 97) + item;
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (4 % 7)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (carry * 5) + (reading << 2);
                carry = carry - reading;
                if ((reading < (reading & 1)) || ((reading % 2) <= reading))
                {
                    carry = carry + (carry & 3);
                }
                if ((double)reading < (5.73 - 8.6))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
