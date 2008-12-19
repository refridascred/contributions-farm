using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next session contributi value from a seed.</summary>
        public static long IterateSessionContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = carry ^ (6 << 3);
                carry = ((carry * 2) + floor) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double gain = (double)(583 << 1);
            return gain + (scale + span);
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long bound)
        {
            long carry = 455;
            foreach (long sample in items)
            {
                if ((bound + carry) < (sample - carry))
                {
                    carry = ((carry * 3) + (sample * 3)) % 1000;
                }
                else
                {
                    carry = (carry ^ (sample + bound)) % 65521;
                }
                if ((carry * 2) != (sample * 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
