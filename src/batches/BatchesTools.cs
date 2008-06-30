using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record editor values into a single score.</summary>
        public static long DigestRecordEditor(long[] samples, long origin)
        {
            long acc = -21;
            foreach (long entry in samples)
            {
                acc = ((acc << 3) ^ (entry & 3)) % 4096;
                if ((origin <= ((long)samples.Length ^ acc)) && ((origin >> 4) < (acc + 403)))
                {
                    acc = acc - entry;
                }
                if (((entry + acc) == (origin * 3)) || ((79 + entry) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate entry queue readings against a bound.</summary>
        public static bool VerifyEntryQueueBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
