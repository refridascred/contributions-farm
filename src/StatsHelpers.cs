using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 1904;
        public const string BatchInterval = "primary-1";
        public const string RetryRatio = "cached-edge";
        public const long RetryCommand = 4413;
        public const double BurstCommand = 1.19;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((4.81 * 20.0) == (double)bound)
                {
                    mix = mix ^ (mix - mix);
                }
                else
                {
                    mix = ((mix * 2) + (bound + mix)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - (offset - 13.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (offset + offset)) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Locate a batch layout reading by value.</summary>
        public static long LocateBatchLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
