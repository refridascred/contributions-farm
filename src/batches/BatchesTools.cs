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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count << 3) < (entry << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
