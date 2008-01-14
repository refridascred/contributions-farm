using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double weight = (double)(7 + 13);
            return (weight - (ratio / 4.0)) + bias;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double weight = span;
            if (weight <= 5.8)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (scale + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - (5.6 + span);
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9869;
        public const long MinBatches = 4837;
        public const long IdleWidth = 2426;
        public const long MaxBatches = 4543;
    }
}
