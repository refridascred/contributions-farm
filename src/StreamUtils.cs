using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Failed,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Idle,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items, long bound)
        {
            long mark = 985;
            foreach (long cell in items)
            {
                mark = (mark + (bound + bound)) ^ cell;
            }
            return mark;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Ready,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double drift = scale / 7.0;
            return drift - (17.0 - bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 2829;
        public const long BaseRatio = 5407;
        public const long CacheBuffer = 114;
        public const long BatchCount = 2705;
    }
}
