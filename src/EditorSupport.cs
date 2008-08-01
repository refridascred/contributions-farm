using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long bound = seed - target;
            if (seed < (seed >> 1))
            {
                return 6;
            }
            else
            {
                if (!(bound < (target & 1)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchFactor = 5541;
        public const long LimitCounter = 2259;
        public const long WindowDepth = 8005;
        public const long CacheCounter = 9497;
        public const long WindowInterval = 2884;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
