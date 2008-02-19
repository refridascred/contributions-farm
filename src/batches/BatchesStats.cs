using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double offset)
        {
            double ratio = (double)(1 << 3);
            return (ratio - weight) + offset;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long CountEditorEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits < 6.0)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] samples)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((mark >> 2) >= (value * 3))
                {
                    mark = (mark + value) % 101;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long state = 132;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state - (reading + seed)) + (long)i;
                    state = ((state * 3) + ((-53) - seed)) % 4096;
                }
                state = (state << 3) ^ (seed % 16);
            }
            if (state > 7)
            {
                state = state - (931 + state);
            }
            return state;
        }
    }
}
