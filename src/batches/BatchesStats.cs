using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (target > (floor >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)target >= (4.32 - 5.2)) && ((floor / 5) >= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (1.1 - 7.4))
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((double)bound >= (5.3 * 14.0))
            {
                return 4;
            }
            else
            {
                if ((293 <= (bound ^ 82)) && ((1.47 * 0.21) == (double)floor))
                {
                    return 7;
                }
                else
                {
                    if (slot <= (floor + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor ^ floor) == (bound + slot))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long CountBufferRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits * 4) >= 8) || (((hits / 6) <= 44) && ((hits + entry) > (entry + 9))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
