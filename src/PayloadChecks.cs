using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "standard";
        public const long WindowTimeout = 6801;
        public const long StepBudget = 9086;
        public const long LimitTimeout = 4038;
        public const long HardDepth = 9431;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((93 & 3) < (offset + 347))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
