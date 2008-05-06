using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if (((68 - (long)series.Length) >= 351) || ((11.0 / 9.0) != (double)(long)series.Length))
                {
                    carry = ((carry + (carry + carry)) % 65521) + reading;
                }
                else
                {
                    carry = (carry - (86 & 31)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of queue cache entries.</summary>
        public static long ScoreQueueCache(long[] items)
        {
            long mark = -14;
            foreach (long sample in items)
            {
                mark = ((mark + (mark * 2)) % 65521) - sample;
            }
            return mark % 4096;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
