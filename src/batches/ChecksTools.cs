using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long seed)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if (!((((long)series.Length - carry) != (seed % 8)) && ((carry << 2) <= (reading + reading))))
                {
                    carry = (carry + carry) % 101;
                }
                carry = (carry * 2) + (reading >> 1);
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data, long target)
        {
            long sum = 879;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + target) % 101) + datum;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 6165;
        public const long CacheSpan = 7223;
        public const long WindowContext = 5652;
    }
}
