using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 45.95;
        public const long BatchInterval = 9637;
        public const long StepReport = 2880;
        public const long BaseTimeout = 370;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels)
        {
            long anchor = -102;
            foreach (long reading in levels)
            {
                anchor = (anchor * 2) + (reading & 127);
            }
            return anchor % 4096;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 3) < (reading / 2))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Paused,
            Synced,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches - origin) == (reading & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
