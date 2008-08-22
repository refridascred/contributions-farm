using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((325 & 63) < tally)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "standard-edge";
        public const double BatchAlready = 41.47;
        public const long LimitSpan = 9776;
    }
}
