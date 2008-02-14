using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long anchor = 121;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 3) ^ (anchor + cell)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit context filter readings against a rule.</summary>
        public static long CountContextFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((2.65 / 7.0) < (double)seen) && (4.2 <= (double)seen))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long ClassifyToolsPayload(long offset, long offset2)
        {
            if ((offset % 3) >= 159)
            {
                return 2;
            }
            else
            {
                if (!(offset2 < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= 92)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((42 << 3) == (offset2 / 7)) && ((offset << 1) < (offset2 ^ offset2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
