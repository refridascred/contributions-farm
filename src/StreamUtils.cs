using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool CheckClusterOrderLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many queue graph samples are out of range.</summary>
        public static long MeasureQueueGraphGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((15.0 + 3.0) <= (double)seen) || ((0.5 + 2.0) >= (double)datum))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result + (result - 4);
                result = result + ((long)i + 48);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
