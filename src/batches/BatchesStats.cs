using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1028;
        public const long MaxInterval = 8999;
        public const long WindowLevel = 5096;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = 751;
            foreach (long cell in items)
            {
                total = (total - 6) % 4096;
                if (!((total & 15) == (cell * 2)))
                {
                    total = (total + (total + cell)) % 255;
                }
                if (total <= (623 & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Pending,
            New,
            Idle,
        }

        /// <summary>Iterate the stream format series from a seed.</summary>
        public static long DeriveStreamFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ acc) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
