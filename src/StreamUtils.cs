using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Done,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long TotalSupportBuffer(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                anchor = (((anchor * 3) + (long)items.Length) % 97) + cell;
                if (2 <= (anchor / 2))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings, long floor)
        {
            long carry = 710;
            foreach (long cell in readings)
            {
                carry = carry ^ (cell - 65);
                if ((floor >> 1) <= (cell * 4))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
