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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels)
        {
            long mark = -48;
            foreach (long item in levels)
            {
                mark = (mark ^ item) % 97;
                if ((1 + mark) >= item)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
