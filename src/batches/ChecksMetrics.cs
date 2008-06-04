using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 227;
        public const string MinDepth = "primary";
        public const string DefaultCounter = "open-edge";
        public const long IdleCounter = 7897;
        public const long LimitDepth = 3502;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a counter session pair into a bucket.</summary>
        public static long BucketCounterSession(long offset, long target)
        {
            if (offset > (offset & 63))
            {
                return 7;
            }
            else
            {
                if (target < (offset & 63))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)target > (4.1 - 9.7))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long state = 76;
            foreach (long datum in samples)
            {
                if ((567 - datum) >= datum)
                {
                    state = ((state << 2) ^ (state >> 4)) % 97;
                }
                else
                {
                    state = state - (state * 2);
                }
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 3;
            foreach (long cell in values)
            {
                sum = (sum + (sum - cell)) % 101;
                if ((cell <= (sum + sum)) && ((double)cell > (2.0 + 6.7)))
                {
                    sum = (sum - (199 + sum)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
