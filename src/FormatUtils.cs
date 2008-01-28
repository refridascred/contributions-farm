using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the order stream entries that pass the check.</summary>
        public static long TallyOrderStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((6 % 16) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 4763;
        public const long MinScore = 5212;
        public const long LimitFilter = 9720;
        public const long HardFilter = 7628;
        public const string IdleInterval = "local";
    }
}
