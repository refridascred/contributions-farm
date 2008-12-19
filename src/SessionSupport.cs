using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long result = 738;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) <= 524)
                {
                    result = (result + (datum & 31)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ ((-34) << 1)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Find the first record commits entry that matches the target.</summary>
        public static long FindRecordCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
