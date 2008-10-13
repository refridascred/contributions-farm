using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(target >= 21))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Done,
            New,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a schema already value against two limits.</summary>
        public static long ClassifySchemaAlready(long target, long offset)
        {
            long span = target ^ offset;
            if ((span + target) < (offset + target))
            {
                return 5;
            }
            else
            {
                if ((span ^ target) == (offset ^ span))
                {
                    return 1;
                }
                else
                {
                    if ((target - target) > (span ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 2) < span))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
