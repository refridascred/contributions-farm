using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double weight = (gain * 3.1) / 9.0;
            if (weight < gain)
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)1) + (double)(long)i;
            }
            return weight + (double)61;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value * 2) == (value + value))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed + seed) <= (entry & 255))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                mark = (((mark * 5) + (mark ^ mark)) % 255) ^ sample;
            }
            if (mark > (-881))
            {
                mark = mark + mark;
            }
            return mark;
        }
    }
}
