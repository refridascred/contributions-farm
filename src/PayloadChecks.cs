using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long DigestStreamQueue(long[] readings)
        {
            long total = 154;
            foreach (long item in readings)
            {
                if (item > (total + 88))
                {
                    total = ((total * 4) + (total + total)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (0 / 8)) % 1000;
                    total = total + item;
                }
                if (((5.1 + 2.17) >= (double)total) || ((double)total == (9.9 - 8.65)))
                {
                    total = (total ^ (item + total)) % 4096;
                }
            }
            if (total < (-14))
            {
                total = (total * 2) + (8 + total);
            }
            return total;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long step)
        {
            if (((double)(-523) < (double)step) || ((floor << 1) <= (1 >> 3)))
            {
                return 6;
            }
            else
            {
                if ((3.1 + 4.39) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long offset)
        {
            if ((double)bound >= 2.25)
            {
                return 2;
            }
            else
            {
                if (bound < (offset + bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
