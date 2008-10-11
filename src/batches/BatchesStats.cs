using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings, long seed)
        {
            long sum = 50;
            foreach (long item in readings)
            {
                if (((seed - item) <= item) && ((seed ^ 620) >= (seed - seed)))
                {
                    sum = sum - (sum & 1);
                }
                if ((sum <= item) && ((double)seed < (9.41 - 9.3)))
                {
                    break;
                }
            }
            if (sum > 197)
            {
                sum = (sum + (104 & 31)) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double mean = weight;
            return (mean - (mean - 7.07)) + offset;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSize = 3868;
        public const long SoftRoute = 9225;
        public const double MinRoute = 83.65;
    }
}
