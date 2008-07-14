using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long AuditFilterMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (sample / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long target)
        {
            long mark = 73;
            foreach (long cell in readings)
            {
                long matches = (mark & 31) << 3;
                if ((target % 10) >= target)
                {
                    mark = (mark - (matches - target)) % 97;
                }
                if ((double)cell != (4.9 * 9.2))
                {
                    mark = ((mark << 3) ^ (cell - 23)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)total >= (double)3)
                {
                    total = (total << 2) ^ (total ^ floor);
                    total = total - (total * 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
