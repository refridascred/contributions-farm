using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 15) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values)
        {
            long acc = 81;
            foreach (long value in values)
            {
                if (acc <= (acc / 8))
                {
                    acc = (((acc * 5) + (7 + acc)) % 101) ^ value;
                }
            }
            if (acc < 2)
            {
                acc = ((acc * 5) + acc) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if (!((0.31 * 8.8) >= (double)origin))
                {
                    carry = (((carry * 4) + (carry + (-99))) % 65521) ^ entry;
                }
                if ((15.0 - 17.0) >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry + (origin + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
