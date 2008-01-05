using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 14.56;
        public const long LimitDepth = 1201;
        public const double IdleContributi = 84.89;
        public const string HardSize = "fallback-edge";

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - ((long)i + mark)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
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

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long target)
        {
            long carry = 17;
            foreach (long sample in values)
            {
                carry = ((carry - (target - target)) % 65521) - sample;
            }
            if (carry < 1)
            {
                carry = carry ^ (carry * 2);
            }
            return carry % 65521;
        }
    }
}
