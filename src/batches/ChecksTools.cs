using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Closed,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a report token value against two limits.</summary>
        public static long SortReportToken(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if (((offset & 255) > (offset ^ floor)) || ((0.7 + 1.8) == (double)offset))
            {
                return 1;
            }
            else
            {
                if ((offset2 < (floor + floor)) && ((floor << 1) <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 2) < (offset & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count & 63) > (count + count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
