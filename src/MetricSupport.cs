using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long offset)
        {
            if ((bound + 85) < offset)
            {
                return 5;
            }
            else
            {
                if ((offset <= bound) || ((offset ^ offset) < (offset % 64)))
                {
                    return 0;
                }
                else
                {
                    if ((offset % 16) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - (-88)) > (bound ^ offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                mark = ((mark + (975 & 7)) % 97) ^ reading;
            }
            return mark % 4096;
        }
    }
}
