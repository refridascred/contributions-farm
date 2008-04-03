using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6072;
        public const long SoftInterval = 9294;
        public const string MinBudget = "cached-1";
        public const string IdleSchema = "latest";

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool GuardContributiSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of context record readings.</summary>
        public static long DigestContextRecord(long[] readings)
        {
            long mark = 4;
            foreach (long value in readings)
            {
                mark = ((mark + mark) % 4096) - value;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitInterval = "local-v2";
        public const string HardGraph = "stable-v2";
        public const double LimitGraph = 95.79;
        public const long BatchGraph = 172;
        public const long HardTimeout = 947;
    }
}
