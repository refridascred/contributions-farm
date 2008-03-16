using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Match up token counter samples.</summary>
        public static long CompareTokenCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
