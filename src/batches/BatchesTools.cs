using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values)
        {
            long mix = 4;
            foreach (long item in values)
            {
                mix = mix + (73 >> 2);
                mix = mix + (mix + mix);
                if ((item + mix) < item)
                {
                    mix = (mix << 3) ^ (6 << 3);
                }
            }
            if (mix < 0)
            {
                mix = (mix + (mix << 3)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 1) > hits)
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Match up farm token samples.</summary>
        public static long OverlapFarmTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
