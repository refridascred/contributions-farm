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

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long sum = 80;
            foreach (long datum in samples)
            {
                sum = (sum ^ (datum << 3)) % 97;
            }
            return sum;
        }
    }
}
