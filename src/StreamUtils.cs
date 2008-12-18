using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of graph profile entries.</summary>
        public static long TallyGraphProfile(long[] values)
        {
            long acc = 413;
            foreach (long datum in values)
            {
                if ((double)481 >= (9.1 + 20.0))
                {
                    acc = acc - (datum & 31);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 3;
            foreach (long cell in items)
            {
                if (score >= (score + 5))
                {
                    score = score + score;
                }
                if ((cell + cell) < ((long)items.Length ^ cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of entry buffer readings.</summary>
        public static long CompareEntryBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
