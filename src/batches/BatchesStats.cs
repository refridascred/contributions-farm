using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = state - (offset + state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2779;
        public const string BaseStats = "alpha-edge";
        public const long DefaultScore = 8102;
        public const long CacheStats = 4408;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading / 7))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
