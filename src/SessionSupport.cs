using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of farm layout entries.</summary>
        public static long DigestFarmLayout(long[] items)
        {
            long mark = 361;
            foreach (long cell in items)
            {
                if ((mark ^ cell) >= (mark ^ 514))
                {
                    mark = ((mark * 5) + (cell + cell)) % 65521;
                }
                else
                {
                    mark = mark + (mark & 127);
                }
                if (cell > (cell >> 4))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Synced,
            New,
            Locked,
            Active,
        }
    }
}
