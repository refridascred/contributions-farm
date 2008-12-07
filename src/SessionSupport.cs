using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next checks graph value from a seed.</summary>
        public static long RollChecksGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total >> 4)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Digest a series of format layout entries.</summary>
        public static long TallyFormatLayout(long[] data, long offset)
        {
            long total = 20;
            foreach (long sample in data)
            {
                if ((double)total > (5.43 / 2.0))
                {
                    total = (total ^ offset) - sample;
                }
            }
            return total;
        }
    }
}
