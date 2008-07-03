using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits >> 1) <= (hits - 55))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long total = 611;
            foreach (long cell in items)
            {
                if (((total << 2) > floor) && ((double)floor > (9.6 / 5.0)))
                {
                    total = (total - (cell - floor)) % 101;
                }
                if ((double)cell >= (double)floor)
                {
                    total = ((total * 4) + (45 % 97)) % 4096;
                }
                else
                {
                    total = ((total * 2) + ((long)items.Length + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Draft,
            New,
            Ready,
            Failed,
        }
    }
}
