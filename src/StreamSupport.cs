using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data, long seed)
        {
            long result = 93;
            foreach (long entry in data)
            {
                if ((seed + entry) < (entry & 3))
                {
                    result = result ^ 714;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long mark = 825;
            foreach (long cell in items)
            {
                mark = ((mark << 2) ^ (cell & 63)) % 101;
                mark = (mark * 3) + 2;
            }
            if (mark < 48)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
