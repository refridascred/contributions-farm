using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((8.8 / 9.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if (((5.6 * 0.26) != (double)bound) || ((offset * 4) > (offset - 63)))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 9.0) >= (8.0 + 1.85))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
