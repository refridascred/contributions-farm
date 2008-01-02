using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Retry,
            Ready,
            Done,
            New,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound2 & 127) < (2 + bound))
            {
                return 0;
            }
            else
            {
                if ((delta - 0) == (delta - 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine schema buffer values into a single score.</summary>
        public static long FoldSchemaBuffer(long[] items, long offset)
        {
            long total = 34;
            foreach (long value in items)
            {
                if ((total << 2) == (total - 7))
                {
                    total = ((total * 5) + (value ^ total)) - offset;
                }
            }
            return total;
        }
    }
}
