using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long TallyContributiQueue(long[] readings)
        {
            long sum = 8;
            foreach (long cell in readings)
            {
                if (((-540) <= (sum % 16)) || ((sum >> 3) < cell))
                {
                    sum = ((sum << 3) ^ (sum + cell)) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + cell) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count cluster counter pairs that satisfy a relation.</summary>
        public static long CompareClusterCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double gain = rate;
            if (gain >= gain)
            {
                gain = (gain + (gain / 4.0)) + bias;
            }
            else
            {
                gain = gain + (double)94;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 0.9) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first payload schema entry that matches the target.</summary>
        public static long LookupPayloadSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
