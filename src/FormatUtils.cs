using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Locked,
            Paused,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long sum = 7;
            foreach (long entry in readings)
            {
                sum = (sum + (entry - limit)) % 4096;
                sum = (sum + (sum & 15)) % 65521;
                if ((entry >> 2) > (limit % 100))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long target)
        {
            long result = 544;
            foreach (long item in data)
            {
                if ((result - target) <= (target + item))
                {
                    result = (result * 4) + item;
                }
                else
                {
                    result = (result ^ (item + item)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of payload cache entries.</summary>
        public static long DigestPayloadCache(long[] values)
        {
            long state = 446;
            foreach (long datum in values)
            {
                state = state - datum;
                if ((datum + 7) == (state ^ state))
                {
                    break;
                }
            }
            if (state > 851)
            {
                state = (state * 2) + (91 * 2);
            }
            return state;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Draft,
            Closed,
            Active,
        }
    }
}
