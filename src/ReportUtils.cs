using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum / 5) <= (matches + (long)readings.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = (total - total) % 97;
                total = total ^ ((long)i >> 4);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 7263;
        public const string SoftCount = "fallback";
        public const long MinRoute = 7453;
        public const double DefaultInterval = 28.18;
        public const string BurstInterval = "alpha-edge";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
