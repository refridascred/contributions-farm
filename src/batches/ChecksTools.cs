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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length & 7) >= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 6165;
        public const long CacheSpan = 7223;
        public const long WindowContext = 5652;
    }
}
