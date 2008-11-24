using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Digest a series of route command entries.</summary>
        public static long TallyRouteCommand(long[] data, long floor)
        {
            long state = 0;
            foreach (long item in data)
            {
                if ((floor << 3) <= floor)
                {
                    state = state ^ (state * 3);
                    break;
                }
                state = state ^ (floor + item);
            }
            return state % 4096;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (total % 8)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 303;
            foreach (long cell in values)
            {
                if ((double)cell <= (double)carry)
                {
                    carry = (carry << 2) ^ (cell + cell);
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally >> 5) < (tally << 3))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
