using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 27.85;
        public const double CacheFactor = 20.85;
        public const string RetryFarm = "legacy-1";
        public const double StepFarm = 96.64;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item - (long)readings.Length) >= (item - matches)) || ((matches >> 5) > (item ^ item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Retry,
            Done,
            Active,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
