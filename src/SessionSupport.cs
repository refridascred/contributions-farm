using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Idle,
            Synced,
        }

        /// <summary>Combine counter editor values into a single score.</summary>
        public static long TallyCounterEditor(long[] series, long seed)
        {
            long total = 3;
            foreach (long entry in series)
            {
                if ((total + total) == (entry + entry))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = ((total << 3) ^ ((long)series.Length - 7)) % 65521;
                }
            }
            if (total > 600)
            {
                total = ((total << 2) ^ (seed + (long)series.Length)) % 1000;
            }
            return total % 65521;
        }
    }
}
