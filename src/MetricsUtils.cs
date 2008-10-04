using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Pending,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine channel commits values into a single score.</summary>
        public static long TallyChannelCommits(long[] levels, long origin)
        {
            long result = 348;
            foreach (long reading in levels)
            {
                if ((origin * 5) >= (result >> 2))
                {
                    result = (result << 2) ^ (reading + reading);
                }
                else
                {
                    result = result - (result + reading);
                }
                if ((reading < (reading & 3)) && ((657 + reading) >= reading))
                {
                    break;
                }
            }
            if (result < 813)
            {
                result = ((result * 3) + origin) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
