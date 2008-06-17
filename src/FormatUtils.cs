using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Stale,
            New,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally % 8) >= tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen < (0.24 * 19.0))
                {
                    seen = ((seen + 3) + entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long total = 23;
            foreach (long cell in readings)
            {
                if ((cell ^ 793) <= (cell + cell))
                {
                    total = (total * 5) + (total ^ 81);
                }
                if ((total > (cell << 3)) || ((cell >> 1) == (total + cell)))
                {
                    total = (total + (total ^ cell)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (total << 2)) % 65521;
                }
            }
            if (total > 7)
            {
                total = (total * 3) + total;
            }
            return total % 4096;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Locked,
            Ready,
            Closed,
            Stale,
        }
    }
}
