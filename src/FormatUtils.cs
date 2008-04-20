using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if ((offset + 3) <= (464 & 255))
            {
                return 1;
            }
            else
            {
                if ((bound2 + offset) <= (93 + bound))
                {
                    return 8;
                }
                else
                {
                    if (bound < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.6 - 6.2) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((14.0 / 2.0) < (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1578;
        public const long MaxCommand = 3429;
        public const long WindowWidth = 5915;
        public const double StepTimeout = 25.01;
        public const long CacheCommand = 5093;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Idle,
            Done,
            Active,
        }
    }
}
