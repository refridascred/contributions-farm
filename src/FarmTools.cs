using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                if (acc < (56 << 2))
                {
                    acc = ((acc << 2) ^ (acc + sample)) % 65521;
                }
            }
            if (acc < 25)
            {
                acc = (acc ^ ((long)levels.Length + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc + offset) % 4096) ^ (long)i2;
                }
                acc = ((acc * 2) + (offset + offset)) % 101;
                if ((acc - (long)i) != (offset % 5))
                {
                    acc = (acc << 3) ^ (offset + acc);
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
