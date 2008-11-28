using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings)
        {
            long total = 83;
            foreach (long value in readings)
            {
                if (((double)value > (19.0 + 3.6)) || ((11.0 / 9.0) != (double)value))
                {
                    total = (total + (value ^ value)) % 1000;
                }
                else
                {
                    total = (total * 2) + (total + 4);
                }
                if (((total & 3) >= (551 >> 2)) && ((total - total) > value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long result = 2;
            foreach (long item in data)
            {
                if (item >= (origin + item))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (origin >> 3)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
