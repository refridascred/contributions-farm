using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Blend two layout batch measurements.</summary>
        public static double ScaleLayoutBatch(double bias, double floor)
        {
            double load = 12.0;
            if (load >= (bias / 2.0))
            {
                load = load + (7.08 - load);
            }
            else
            {
                load = load + floor;
            }
            return load + (load - load);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 8) >= (sample >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 16.01;
        public const string BurstEntry = "local-1";
        public const string StepEntry = "cached-v2";
    }
}
