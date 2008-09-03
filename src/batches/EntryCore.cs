using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Queued,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Retry,
            Done,
            Active,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long limit)
        {
            long mix = 33;
            foreach (long value in levels)
            {
                mix = (mix + (-9)) % 97;
                if (!((double)270 != (double)limit))
                {
                    mix = (mix ^ (mix - mix)) % 101;
                }
                if ((value > (mix & 127)) && ((mix - (-609)) == (limit + value)))
                {
                    mix = (mix ^ (mix >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 6.46;
        public const double WindowNotes = 26.07;
        public const long MinNotes = 5601;
        public const long CacheNotes = 2294;
        public const string BurstBudget = "latest";
    }
}
