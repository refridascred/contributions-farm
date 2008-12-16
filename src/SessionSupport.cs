using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((seed >= (seed & 3)) && (hits < (hits >> 1)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long mix = 87;
            foreach (long entry in readings)
            {
                mix = (((mix * 4) + 241) % 65521) ^ entry;
            }
            return mix;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long result = 276;
            foreach (long item in data)
            {
                if ((item * 3) < (item + result))
                {
                    result = (result - (item - item)) + step;
                }
            }
            return result;
        }
    }
}
