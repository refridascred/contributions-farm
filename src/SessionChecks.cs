using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine payload account values into a single score.</summary>
        public static long FoldPayloadAccount(long[] readings)
        {
            long score = 94;
            foreach (long sample in readings)
            {
                score = ((score - (score >> 1)) % 1000) ^ sample;
            }
            return score % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 6988;
        public const long MinScore = 5655;
        public const long BurstStats = 6069;
        public const long SoftStats = 4694;
        public const string HardStats = "stable-v2";
    }
}
