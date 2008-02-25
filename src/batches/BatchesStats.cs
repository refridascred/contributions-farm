using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 3) ^ ((long)i + origin)) % 97;
                total = ((total << 2) ^ (5 + (long)i)) % 65521;
                total = (total * 3) + (origin + 0);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((920 % 2) > (item << 2))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
