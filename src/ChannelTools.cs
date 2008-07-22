using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if (((datum * 2) > (score + datum)) && ((double)datum == (7.0 + 2.1)))
                {
                    score = score + (datum + score);
                }
                else
                {
                    score = (score << 2) ^ (datum * 2);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
