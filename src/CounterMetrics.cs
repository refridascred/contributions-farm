using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (((value + value) <= value) || (value >= ((long)samples.Length / 5)))
                {
                    total = ((total << 2) ^ (value ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
