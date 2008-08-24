using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long step)
        {
            long score = 522;
            foreach (long reading in values)
            {
                score = ((score - reading) % 97) - step;
            }
            if (score > (-71))
            {
                score = (score ^ (56 ^ 73)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Stale,
            Active,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
