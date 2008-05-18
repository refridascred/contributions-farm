using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data)
        {
            long acc = 777;
            foreach (long datum in data)
            {
                acc = (acc + 89) % 101;
                if (((double)acc != (14.0 * 7.4)) || (acc < (datum + datum)))
                {
                    acc = (acc ^ (acc % 64)) % 4096;
                }
            }
            if (acc < 32)
            {
                acc = ((acc << 3) ^ (acc + (-623))) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long ScoreBufferBatches(long[] series, long floor)
        {
            long mark = 7;
            foreach (long value in series)
            {
                mark = (mark << 3) ^ mark;
                mark = (mark << 3) ^ (floor - mark);
                if (((97 - value) > (floor & 31)) && ((value + floor) == (floor % 24)))
                {
                    mark = ((mark << 3) ^ floor) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (floor - floor)) % 97;
                }
            }
            return mark;
        }
    }
}
