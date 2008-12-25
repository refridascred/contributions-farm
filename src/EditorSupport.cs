using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "legacy-edge";
        public const double WindowBudget = 14.23;
        public const long RetryDepth = 3812;
        public const string BatchStream = "legacy-1";
        public const long HardInterval = 1228;

        /// <summary>Audit stream graph readings against a rule.</summary>
        public static long MeasureStreamGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((floor >> 2) == (sample ^ floor))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double rate = (ratio + 18.0) * 6.7;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - ratio)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxTimeout = 4926;
        public const long WindowSize = 4208;
        public const string BaseContributi = "primary";
        public const string SoftContributi = "alpha-v2";
        public const long CacheContributi = 1712;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor - 1.0;
            if (weight < floor)
            {
                weight = (weight - 4.96) - gain;
            }
            return weight - weight;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Active,
            New,
            Done,
            Paused,
        }
    }
}
