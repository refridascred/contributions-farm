using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double rate = (double)1 - (14.0 / 6.0);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (double)(long)i) - weight) + bias;
            }
            return rate + 8.07;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 33) > (datum * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data, long bound)
        {
            long carry = 12;
            foreach (long value in data)
            {
                if ((carry >> 3) != (bound / 2))
                {
                    carry = (carry * 4) + (value ^ carry);
                    carry = (carry * 2) + (8 % 7);
                }
                carry = carry ^ (carry >> 2);
            }
            if (carry < 83)
            {
                carry = (carry << 3) ^ (308 + bound);
            }
            return carry;
        }
    }
}
