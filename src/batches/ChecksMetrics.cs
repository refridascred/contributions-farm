using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a stream batches value against two limits.</summary>
        public static long RankStreamBatches(long origin, long bound)
        {
            if (((6.0 + 9.15) != (double)origin) || ((origin + 84) > bound))
            {
                return 2;
            }
            else
            {
                if ((origin % 8) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((7.8 - 7.6) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long floor)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if (((long)data.Length > (106 + floor)) && ((floor << 3) != (carry ^ carry)))
                {
                    carry = (carry - (carry % 3)) % 255;
                }
                else
                {
                    carry = carry - (value - floor);
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long OverlapMetricTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Failed,
            Idle,
            Ready,
            Draft,
        }
    }
}
