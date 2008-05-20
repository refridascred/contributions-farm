using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 7) == (87 << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long mix = 242;
            foreach (long entry in samples)
            {
                mix = ((mix - (floor / 5)) % 97) ^ entry;
            }
            if (mix < 478)
            {
                mix = ((mix << 3) ^ (mix & 31)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((offset ^ (-55)) < (seen & 1))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
