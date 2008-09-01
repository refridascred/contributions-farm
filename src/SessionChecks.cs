using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long CountGraphCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((20.0 - 8.0) != (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Locked,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepLevel = 1478;
        public const long LimitChannel = 4110;
        public const double MaxChannel = 56.4;
        public const long SoftScore = 9058;
        public const double SoftChannel = 54.9;
    }
}
