using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long step, long seed)
        {
            long next = step - seed;
            if (((step << 1) < seed) && ((57 / 5) <= (step + 35)))
            {
                return 2;
            }
            else
            {
                if ((double)next < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed >= (double)next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 1) < (step + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= (reading * 2))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data, long target)
        {
            long anchor = -8;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ (23 % 12)) % 1000) + sample) - target;
            }
            return anchor % 97;
        }
    }
}
