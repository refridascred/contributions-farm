using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mark = 591;
            foreach (long sample in readings)
            {
                if ((mark - mark) > sample)
                {
                    mark = (mark + (278 * 3)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9790;
        public const long RetryNotes = 8900;
        public const string BurstLevel = "strict-1";

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
