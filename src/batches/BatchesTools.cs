using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long limit)
        {
            long carry = 81;
            foreach (long entry in data)
            {
                carry = (carry * 2) + (76 ^ carry);
                if ((8.0 <= (double)limit) || (((long)data.Length - entry) == (carry - 27)))
                {
                    carry = ((carry * 2) + limit) % 255;
                }
                if ((double)limit == (9.33 - 1.4))
                {
                    break;
                }
            }
            if (carry < 30)
            {
                carry = (carry + (limit + 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Locked,
            New,
        }
    }
}
