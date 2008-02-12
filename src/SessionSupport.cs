using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ (total >> 3);
                total = (total << 2) ^ (origin >> 1);
                if (((origin ^ total) == ((long)i & 15)) || ((double)total > (double)95))
                {
                    total = ((total * 4) + (total & 7)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
