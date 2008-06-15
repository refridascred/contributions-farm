using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry - offset) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count - count) == (reading % 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long edge = offset - step;
            if (((double)edge >= 5.8) || ((offset << 2) < offset))
            {
                return 3;
            }
            else
            {
                if ((43 & 255) < edge)
                {
                    return 0;
                }
                else
                {
                    if (((offset - offset) < (edge + offset)) && ((offset + step) < (edge * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ step) <= (edge >> 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
