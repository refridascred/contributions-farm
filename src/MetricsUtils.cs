using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Synced,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit + total) > (limit >> 1)) || (limit >= total))
                {
                    total = ((total * 4) + (5 & 63)) % 255;
                    total = total ^ (379 + limit);
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    total = (total - limit) + (long)i3;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Locked,
            New,
            Ready,
            Idle,
        }
    }
}
