using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double weight = 0.5;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (offset + 14.0)) + (double)(long)i) - rate;
            }
            return weight + (double)29;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Queued,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long seed, long target)
        {
            if ((target & 127) < seed)
            {
                return 8;
            }
            else
            {
                if (!(seed <= (seed * 5)))
                {
                    return 5;
                }
                else
                {
                    if (!(target > (target % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph account entries.</summary>
        public static long DigestGraphAccount(long[] levels, long limit)
        {
            long carry = 0;
            foreach (long value in levels)
            {
                if (limit > (value % 64))
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
        }
    }
}
