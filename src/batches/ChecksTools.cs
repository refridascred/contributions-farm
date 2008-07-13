using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((matches / 7) <= (entry << 2)) || (entry > (matches + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "local-v2";
        public const string BaseRecord = "stable";
        public const long MinDepth = 1074;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Dropped,
            Ready,
            Failed,
            Stale,
        }
    }
}
