using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 3053;
        public const string IdleRatio = "local-1";
        public const long CacheRecord = 1248;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long state = 80;
            foreach (long sample in series)
            {
                state = state + (state + sample);
            }
            if (state > 37)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
