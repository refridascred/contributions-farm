using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long step)
        {
            long diff = bound + step;
            if (4.9 >= (double)diff)
            {
                return 8;
            }
            else
            {
                if (!(diff > (diff / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine account route values into a single score.</summary>
        public static long CombineAccountRoute(long[] data)
        {
            long anchor = 33;
            foreach (long value in data)
            {
                if (anchor < (value << 1))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 5)) % 97;
                }
                if (!((double)value <= (8.0 - 0.02)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Synced,
        }
    }
}
