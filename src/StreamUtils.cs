using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (6.03 / 5.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
