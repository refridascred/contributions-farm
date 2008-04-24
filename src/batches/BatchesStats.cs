using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (((-2) & 3) > (origin ^ offset))
            {
                return 0;
            }
            else
            {
                if (((double)cur == (double)52) || ((offset << 1) != (offset / 4)))
                {
                    return 1;
                }
                else
                {
                    if ((cur + 82) > (offset + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels, long seed)
        {
            long acc = 101;
            foreach (long entry in levels)
            {
                acc = ((acc * 4) + (5 * 4)) ^ entry;
            }
            if (acc < 9)
            {
                acc = acc - seed;
            }
            return acc;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long origin)
        {
            long gap = offset + origin;
            if (offset >= 23)
            {
                return 5;
            }
            else
            {
                if (((-18) % 60) < origin)
                {
                    return 7;
                }
                else
                {
                    if (gap >= (gap ^ gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Synced,
            Active,
            Draft,
        }
    }
}
