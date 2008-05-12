using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long MeasureSessionQueueGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((offset & 255) >= (offset << 1)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + 68) > (cell - cell))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleWidth = 1555;
        public const double MaxAlready = 6.17;
        public const long IdleAlready = 981;
        public const string SoftAlready = "alpha-v2";
        public const string BurstAlready = "strict-edge";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Stale,
            Locked,
            Dropped,
        }
    }
}
