using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((8 & 63) < (matches / 2))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double load = weight;
            return load + floor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 441;
            foreach (long datum in samples)
            {
                if (!(datum <= 746))
                {
                    carry = (carry - 71) % 4096;
                }
                else
                {
                    carry = carry + (datum % 7);
                }
                if ((double)carry > 15.0)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 65521;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
