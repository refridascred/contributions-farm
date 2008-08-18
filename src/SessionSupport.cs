using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a buffer farm reading by value.</summary>
        public static long FindBufferFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Roll a support entry counter forward.</summary>
        public static long RollSupportEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = mark ^ (bound + (long)i);
                mark = ((mark << 3) ^ ((long)i + mark)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
