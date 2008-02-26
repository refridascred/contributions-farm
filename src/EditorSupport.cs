using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target * 5) <= (target << 3))
                {
                    total = ((total * 2) + (long)i) % 255;
                    total = ((total * 5) + ((long)i - target)) % 101;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate schema cluster samples.</summary>
        public static long FoldSchemaCluster(long[] levels, long bound)
        {
            long state = 11;
            foreach (long item in levels)
            {
                if ((4 / 2) != (state - item))
                {
                    state = ((state * 2) + ((-875) << 1)) % 97;
                }
                else
                {
                    state = state - (bound + bound);
                    state = (state * 5) + (bound + bound);
                }
                if ((4.75 / 7.0) == (double)item)
                {
                    state = ((state << 3) ^ bound) % 65521;
                }
                else
                {
                    state = (state ^ (state + 75)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
