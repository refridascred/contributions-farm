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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
