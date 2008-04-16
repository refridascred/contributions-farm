using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Stale,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Failed,
            Active,
            New,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
