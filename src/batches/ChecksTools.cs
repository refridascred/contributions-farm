using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up queue stream samples.</summary>
        public static long PairQueueStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                mix = ((mix + (mix & 1)) % 65521) - entry;
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) != (tally + tally)) || (tally > (tally % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] series)
        {
            long mix = 1;
            foreach (long item in series)
            {
                if (item <= (item + mix))
                {
                    mix = (mix - (mix + mix)) % 4096;
                }
                if (((4 / 2) > (item + item)) && ((mix * 2) == (mix - mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
