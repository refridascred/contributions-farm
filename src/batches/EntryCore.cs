using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4600;
        public const long DefaultChannel = 7152;
        public const string MaxRatio = "fallback";
        public const string IdleTimeout = "local";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
