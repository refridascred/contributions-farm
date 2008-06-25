using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstCount = 50.82;
        public const long StepRecord = 5688;
        public const double MinSize = 69.0;
        public const long BurstFactor = 185;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double weight2 = offset + (offset + weight);
            if (weight2 >= weight)
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 - 16.0;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long AuditChannelStreamGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.0 / 6.0) < (double)origin)
                {
                    matches = (matches + 2) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
