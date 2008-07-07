using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double weight = (double)(699 * 3);
            if (weight <= (floor / 7.0))
            {
                weight = weight - 0.6;
            }
            else
            {
                weight = weight - (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySize = "latest-1";
        public const long StepSpan = 6094;
        public const long WindowCommits = 8384;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer contributi samples are out of range.</summary>
        public static long CountBufferContributiGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 2) == (tally & 255))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
