using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long target)
        {
            long carry = -6;
            foreach (long cell in values)
            {
                if ((cell + target) >= carry)
                {
                    carry = (carry - (cell - carry)) % 101;
                }
                else
                {
                    carry = carry + 5;
                }
            }
            if (carry > 6)
            {
                carry = (carry + (55 & 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the buffer tools entries that pass the check.</summary>
        public static long AuditBufferToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((11.0 / 2.0) > (double)seen)
                {
                    seen = ((seen + 1) - value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstRatio = 72.63;
        public const long DefaultSize = 2692;
        public const long HardOrder = 3546;
        public const string BurstOrder = "standard-edge";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Queued,
            Done,
            Retry,
            Idle,
        }
    }
}
