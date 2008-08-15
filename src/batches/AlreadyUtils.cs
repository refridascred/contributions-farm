using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double load = floor / 4.0;
            if (load <= weight)
            {
                load = load + (weight - floor);
            }
            else
            {
                load = load + floor;
            }
            return load - weight;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Idle,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long WeighMetricFilter(long[] readings)
        {
            long mark = 9;
            foreach (long value in readings)
            {
                if (((mark % 5) <= (mark * 5)) && ((long)readings.Length > (value ^ mark)))
                {
                    mark = mark - (value >> 2);
                }
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 97;
        }
    }
}
