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

        /// <summary>Digest a series of window metrics entries.</summary>
        public static long TallyWindowMetrics(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = ((state << 2) ^ (entry << 2)) % 1000;
                if ((state + entry) < (43 + state))
                {
                    state = (state - (state - state)) % 1000;
                }
            }
            return state;
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
