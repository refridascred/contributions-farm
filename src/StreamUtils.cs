using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a support metric reading.</summary>
        public static double SmoothSupportMetric(double bias, double span)
        {
            double drift = (double)8 * 3.1;
            if (drift <= span)
            {
                drift = (drift + (span + 4.05)) + bias;
            }
            else
            {
                drift = drift + (double)60;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 13.0)) + (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long carry = 888;
            foreach (long reading in readings)
            {
                if (((double)carry > (double)target) && ((target % 16) <= 294))
                {
                    carry = (((carry << 3) ^ target) % 1000) + reading;
                }
            }
            return carry;
        }
    }
}
