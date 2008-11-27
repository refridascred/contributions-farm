using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = -418;
            foreach (long entry in levels)
            {
                score = (score ^ 42) % 4096;
                if ((double)entry >= (3.73 - 12.0))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score << 2) ^ origin;
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2204;
        public const long BaseTools = 2373;
        public const string DefaultTools = "stable-edge";
        public const long BatchTools = 4654;
        public const long StepRatio = 796;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels, long step)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                total = (((total * 5) + (step - 1)) % 255) ^ entry;
            }
            if (total < 2)
            {
                total = (total << 2) ^ step;
            }
            return total % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double weight = (1.1 * 3.11) + (double)5;
            if (weight <= (offset + weight))
            {
                weight = weight - (weight / 6.0);
            }
            return weight - (offset + gain);
        }
    }
}
