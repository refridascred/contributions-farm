using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long AuditOrderRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length == (2 & 15))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
