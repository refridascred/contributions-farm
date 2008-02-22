using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long SeekSessionSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long AuditAccountStreamHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen << 1) >= (seen + entry))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
