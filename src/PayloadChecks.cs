using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((target / 9) > (target - matches)) && ((2 * 5) >= (value - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum >= (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Dropped,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Locate a cluster commits reading by value.</summary>
        public static long FindClusterCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 9313;
        public const long BaseChecks = 7937;
        public const long MinChecks = 5069;
    }
}
