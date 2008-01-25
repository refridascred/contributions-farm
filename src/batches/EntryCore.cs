using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long WeighFormatRecord(long[] readings, long bound)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = (acc ^ (bound + 126)) - item;
            }
            if (acc > 5)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Pending,
            Draft,
            Locked,
            New,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit + limit) < 41)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
