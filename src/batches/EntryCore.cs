using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double ratio = 18.0 - (gain + span);
            return ratio - (double)72;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepCount = 86.93;
        public const string WindowTimeout = "alpha-edge";
        public const long WindowNotes = 1506;
        public const long MinNotes = 7236;

        /// <summary>Match up route graph samples.</summary>
        public static long CompareRouteGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
