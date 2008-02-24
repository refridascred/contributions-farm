using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long DeriveChannelTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((6.7 - 13.0) < (double)seen) && (((double)sample <= (14.0 / 5.0)) || ((double)seed != (2.4 - 5.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two queue record measurements.</summary>
        public static double SmoothQueueRecord(double rate, double span)
        {
            double load = span / 2.0;
            return load + rate;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowWidth = "cached-1";
        public const string BaseStats = "cached";
        public const long MinStats = 3377;
        public const long BatchStats = 6890;
        public const long StepStats = 2523;
    }
}
