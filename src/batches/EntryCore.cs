using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the cluster already series from a seed.</summary>
        public static long IterateClusterAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + ((long)i >> 3)) % 1000;
                if ((carry & 15) == (long)i)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count channel checks pairs that satisfy a relation.</summary>
        public static long OverlapChannelChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
