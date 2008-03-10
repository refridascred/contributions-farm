using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long TallyLayoutCounterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (double)matches)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 45.09;
        public const string LimitCount = "standard";
        public const string SoftCommand = "standard-1";
        public const long IdleCommand = 9731;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((577 & 7) <= limit)
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
