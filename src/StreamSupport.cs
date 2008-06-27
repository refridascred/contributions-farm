using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next cluster token value from a seed.</summary>
        public static long RollClusterToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark ^ ((long)i2 ^ step)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of editor stream readings.</summary>
        public static long DigestEditorStream(long[] items)
        {
            long score = 57;
            foreach (long item in items)
            {
                if (11.0 < (double)item)
                {
                    score = score + (item + item);
                }
                score = score - (score / 2);
            }
            return score % 4096;
        }
    }
}
