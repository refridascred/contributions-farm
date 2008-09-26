using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank farm session input into a small class.</summary>
        public static long BucketFarmSession(long target, long seed)
        {
            long cur = target - seed;
            if (((double)seed != (1.3 - 1.76)) && ((cur / 8) > (seed / 2)))
            {
                return 0;
            }
            else
            {
                if (target >= (seed - cur))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
