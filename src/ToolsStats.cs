using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate checks session samples.</summary>
        public static long WeighChecksSession(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (sample > (offset << 1))
                {
                    carry = (carry - carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next graph entry value from a seed.</summary>
        public static long DeriveGraphEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + ((long)i & 63)) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
