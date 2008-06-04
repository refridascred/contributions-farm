using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 2999;
        public const string DefaultPayload = "primary-v2";
        public const long MinWidth = 2439;
        public const long BaseLevel = 3855;
        public const long LimitCount = 1625;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = 92;
            foreach (long item in readings)
            {
                if (mark < (1 - mark))
                {
                    mark = (mark * 2) + (item + item);
                }
            }
            if (mark < 82)
            {
                mark = (mark - (7 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long target)
        {
            if ((target + target) <= (target + offset))
            {
                return 7;
            }
            else
            {
                if ((target << 1) > (offset / 8))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Idle,
            Failed,
            New,
            Paused,
        }
    }
}
