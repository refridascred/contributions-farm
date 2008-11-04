using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 66.6;
        public const double MinCommand = 38.9;
        public const long BurstTimeout = 8246;
        public const long RetrySize = 2144;
        public const long BurstRatio = 3854;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally % 64) >= tally) && ((item - item) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
