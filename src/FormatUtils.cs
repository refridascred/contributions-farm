using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((floor & 1) <= 45)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 26.23;
        public const long MinQueue = 3315;
        public const long StepQueue = 4543;
        public const string BurstSpan = "cached-v2";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
