using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc + 48)) % 4096;
                if ((sample / 5) != (target + target))
                {
                    acc = ((acc * 4) + (0 & 3)) % 65521;
                }
            }
            if (acc > 744)
            {
                acc = ((acc * 2) + (acc / 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items, long offset)
        {
            long sum = 51;
            foreach (long item in items)
            {
                if ((9.37 * 9.0) < (double)item)
                {
                    sum = ((sum * 5) + (sum >> 4)) - offset;
                    sum = sum + ((long)items.Length >> 4);
                }
                sum = ((sum * 3) + (sum + sum)) % 4096;
                sum = sum + (sum % 97);
            }
            if (sum > 514)
            {
                sum = sum - (sum % 3);
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits << 3) >= (floor - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
