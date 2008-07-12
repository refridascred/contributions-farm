using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)65 >= (double)value) && ((value % 97) == (offset * 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((0 << 3) >= total)
                {
                    total = total ^ (long)i;
                }
                if (total > (total + total))
                {
                    total = (total + (long)i) % 101;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if ((seed % 8) == (seed / 2))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset + 39))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (offset << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Failed,
            Locked,
        }
    }
}
