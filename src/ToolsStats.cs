using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many buffer payload samples are out of range.</summary>
        public static long MeasureBufferPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count <= (8 >> 3)) || ((datum >> 1) <= datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long DigestToolsChecks(long[] levels, long offset)
        {
            long mark = 76;
            foreach (long cell in levels)
            {
                mark = ((mark ^ (mark ^ cell)) % 4096) - offset;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a payload cache sample.</summary>
        public static long LookupPayloadCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = (1.0 - bias) - (bias + bias);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (bias + 8.0);
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Queued,
            Active,
            Dropped,
        }
    }
}
