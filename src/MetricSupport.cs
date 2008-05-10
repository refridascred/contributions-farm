using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftInterval = 57.4;
        public const string SoftWidth = "local";
        public const long BurstChannel = 9512;
        public const long BurstDepth = 9372;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < 974)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Match up token counter samples.</summary>
        public static long MatchTokenCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
