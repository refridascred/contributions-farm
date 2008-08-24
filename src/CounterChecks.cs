using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long carry = 80;
            foreach (long cell in samples)
            {
                if (((-4) < (cell + cell)) && ((carry * 3) > cell))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < (-799))
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Ready,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long anchor = 951;
            foreach (long entry in levels)
            {
                anchor = ((anchor - (anchor * 3)) % 1000) - entry;
            }
            if (anchor > 548)
            {
                anchor = ((anchor * 2) + 2) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((276 % 2) >= (value ^ 750))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings, long target)
        {
            long sum = -35;
            foreach (long item in readings)
            {
                if (!((double)item == (9.0 * 9.38)))
                {
                    sum = ((sum * 3) + (item & 63)) + target;
                }
                if (((sum - 6) > item) && ((item << 1) <= (sum & 3)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
