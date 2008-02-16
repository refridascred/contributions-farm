using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (34 < (datum - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long AuditRecordLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ sample) == (4 >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Failed,
            Paused,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "alpha-edge";
        public const long BurstSpan = 2140;
        public const long BurstLayout = 2667;
        public const long HardInterval = 8722;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Paused,
            Pending,
            Retry,
            Failed,
        }
    }
}
