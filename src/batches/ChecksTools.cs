using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
