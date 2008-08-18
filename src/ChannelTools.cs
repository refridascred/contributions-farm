using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits <= (736 / 8)) && ((hits - 3) >= (hits + hits)))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long AuditToolsChannelGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (offset - seen)) || (((datum - datum) == (offset % 97)) && ((datum + 116) <= datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > ((long)i % 97))
                {
                    sum = ((sum * 4) + (bound + 16)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
