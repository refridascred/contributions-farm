using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > 9.31)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long floor)
        {
            if (floor < (3 ^ 73))
            {
                return 8;
            }
            else
            {
                if ((floor ^ target) >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
