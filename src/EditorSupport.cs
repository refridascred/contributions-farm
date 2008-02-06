using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long target)
        {
            long mix = 16;
            foreach (long item in samples)
            {
                if ((165 / 4) >= mix)
                {
                    mix = (((mix + mix) % 255) ^ item) - target;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 423;
            foreach (long reading in items)
            {
                if (reading >= (50 >> 5))
                {
                    mix = (mix + mix) % 4096;
                }
                else
                {
                    mix = mix + (326 & 15);
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long MeasureAlreadyBatchHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset - sample) == (count / 6))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
