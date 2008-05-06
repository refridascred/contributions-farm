using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 7786;
        public const string MaxAlready = "stable";
        public const long IdleAlready = 5783;
        public const long LimitAlready = 1593;
        public const long DefaultAlready = 2714;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of contributi counter readings.</summary>
        public static long CompareContributiCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Validate channel stats readings against a bound.</summary>
        public static bool GuardChannelStatsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
