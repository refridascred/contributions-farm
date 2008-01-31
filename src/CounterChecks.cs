using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (result & 3)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally - 76) > 15)
                {
                    tally = ((tally + 2) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Synced,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "latest-1";
        public const long StepFormat = 5705;
        public const long StepSpan = 7239;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
