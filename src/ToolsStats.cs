using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double mean = ratio - (double)6;
            if (mean < ratio)
            {
                mean = (mean + (double)93) - offset;
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 3981;
        public const long WindowDepth = 1548;
        public const long BatchCount = 2298;
        public const double StepMetrics = 73.52;
        public const long HardDepth = 5198;

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale - (double)1;
            }
            return scale + (scale + span);
        }
    }
}
