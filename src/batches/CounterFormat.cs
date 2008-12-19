using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long bound)
        {
            long sum = 7;
            foreach (long reading in series)
            {
                sum = ((sum * 5) + (reading - bound)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            New,
            Locked,
            Paused,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
