using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            if (target > (target - target))
            {
                return 2;
            }
            else
            {
                if ((double)floor < 9.0)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Retry,
            New,
            Done,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long state = 8;
            foreach (long reading in series)
            {
                state = ((state << 2) ^ (reading - reading)) % 97;
                state = (state ^ (state >> 2)) % 101;
            }
            if (state < 669)
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }
    }
}
