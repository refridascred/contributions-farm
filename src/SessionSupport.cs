using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4343;
        public const long BatchSize = 7718;
        public const long SoftChannel = 2727;
        public const string BurstBudget = "strict-1";
        public const long LimitChannel = 8264;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                if (((mark * 5) <= sample) && ((double)mark > (2.6 - 8.0)))
                {
                    mark = (mark + (sample * 3)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + (sample / 6)) % 255;
                }
            }
            return mark;
        }
    }
}
