using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long limit)
        {
            long cur = step ^ limit;
            if (7.8 < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((92 + 644) != (limit - cur))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) == (step / 8)) && ((0 + cur) >= (limit << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster token readings.</summary>
        public static long MatchClusterTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if ((sum - (long)i) < ((long)i - sum))
                {
                    sum = (sum ^ (sum ^ target)) % 255;
                    sum = ((sum << 2) ^ sum) % 1000;
                    break;
                }
                else
                {
                    sum = (sum ^ sum) % 255;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
