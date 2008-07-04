using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the githubfarm graph entries that pass the check.</summary>
        public static long CountGithubfarmGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 5) <= 533)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings, long step)
        {
            long carry = 134;
            foreach (long entry in readings)
            {
                if (63 < (step % 16))
                {
                    carry = (carry ^ step) ^ entry;
                }
                if ((carry & 7) > carry)
                {
                    carry = carry - 8;
                }
            }
            if (carry > 13)
            {
                carry = carry ^ step;
            }
            return carry;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
