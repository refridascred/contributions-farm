using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cache token readings against a rule.</summary>
        public static long TallyCacheTokenGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >= (9 - cell)) || ((floor <= (491 / 8)) && (cell < (290 + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + 0) >= (568 >> 4))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + datum) <= ((long)readings.Length - datum))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
