using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((6.0 - 5.3) < (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples)
        {
            long anchor = -72;
            foreach (long item in samples)
            {
                if ((item - anchor) > item)
                {
                    anchor = (anchor - (item + anchor)) % 65521;
                }
            }
            if (anchor > 16)
            {
                anchor = anchor ^ (9 + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleDepth = "strict-v2";
        public const long SoftOrder = 2662;
        public const long BurstOrder = 4021;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double bias)
        {
            double rate = (double)(96 % 16);
            if (rate < weight)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)44) + (double)(long)i;
            }
            return rate - (double)76;
        }
    }
}
