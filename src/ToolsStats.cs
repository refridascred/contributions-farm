using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 5299;
        public const string RetryRatio = "fallback-1";
        public const string BatchDepth = "strict-1";
        public const double DefaultContributi = 14.13;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Active,
            Paused,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((offset % 10) < (54 << 3)) || ((matches + matches) <= offset))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long carry = 807;
            foreach (long item in readings)
            {
                if ((9.0 / 4.0) > (double)item)
                {
                    carry = ((carry << 3) ^ (item << 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Done,
            Closed,
        }
    }
}
