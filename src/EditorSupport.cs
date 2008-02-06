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

        /// <summary>Digest a series of format cache entries.</summary>
        public static long ScoreFormatCache(long[] data, long seed)
        {
            long score = 957;
            foreach (long sample in data)
            {
                if ((score & 63) == (score + (-192)))
                {
                    score = ((score << 2) ^ (score ^ sample)) % 65521;
                }
            }
            if (score < (-86))
            {
                score = ((score << 2) ^ seed) % 101;
            }
            return score;
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
