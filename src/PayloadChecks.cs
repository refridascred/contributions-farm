using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support farm entries.</summary>
        public static long TotalSupportFarm(long[] samples)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if (12.0 <= (double)value)
                {
                    state = (state + (state & 31)) % 97;
                }
                else
                {
                    state = state - value;
                }
            }
            return state;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long bound)
        {
            if ((target >> 4) != (target << 1))
            {
                return 5;
            }
            else
            {
                if ((2.0 * 7.27) >= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((bound / 9) <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)target >= (4.87 + 8.3)) && ((double)bound <= 7.08))
                        {
                            return 2;
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
