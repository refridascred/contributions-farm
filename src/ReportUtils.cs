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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)value != (6.29 - 1.6)) || (tally < (value ^ tally))) && (tally > (value ^ 42)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Iterate the commits editor series from a seed.</summary>
        public static long IterateCommitsEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
