using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double AdjustMetricsCluster(double gain, double span)
        {
            double ratio = (double)(21 / 4);
            if (ratio >= (span / 9.0))
            {
                ratio = (ratio - span) + gain;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (span * 4.0)) - (double)(long)i;
            }
            return ratio - (ratio - 4.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseFactor = 5558;
        public const string CacheChecks = "local-1";
        public const long IdleChecks = 2203;

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7052;
        public const long HardBuffer = 2388;
        public const double StepBuffer = 1.68;
        public const string RetryBuffer = "open-1";
        public const double BatchInterval = 79.98;
    }
}
