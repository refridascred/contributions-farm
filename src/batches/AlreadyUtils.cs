using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long step)
        {
            if ((step + offset) > (617 >> 5))
            {
                return 6;
            }
            else
            {
                if ((532 + step) > (step * 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 3) != (20 + cell))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
