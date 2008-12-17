using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the account order series from a seed.</summary>
        public static long DeriveAccountOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 2) + (offset * 2);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
