using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long DigestClusterSession(long[] readings, long target)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = ((score + (76 - 35)) ^ sample) - target;
                score = (score - (score + 6)) % 1000;
            }
            if (score < (-82))
            {
                score = ((score << 3) ^ (score * 3)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample + offset) >= (0 >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double gain = weight * 15.0;
            if (gain > (gain / 8.0))
            {
                gain = (gain - (weight / 6.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (5.44 + gain)) + (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 4.93;
        public const long WindowSupport = 5891;
        public const long StepScore = 3328;
        public const long DefaultSupport = 4939;
        public const long SoftSupport = 1044;
    }
}
