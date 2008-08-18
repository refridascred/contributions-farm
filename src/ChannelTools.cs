using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
