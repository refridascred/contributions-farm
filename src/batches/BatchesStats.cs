using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long BurstSpan = 5170;
        public const string WindowLevel = "local-edge";
        public const double LimitSupport = 74.56;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double rate = bias2 - (bias + bias2);
            if (rate > (double)99)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + bias2;
            }
            return rate + rate;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
