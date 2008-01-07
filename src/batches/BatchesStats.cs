using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            New,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of already commits readings.</summary>
        public static long CombineAlreadyCommits(long[] series)
        {
            long result = 12;
            foreach (long cell in series)
            {
                result = (result << 3) ^ (cell / 4);
                result = ((result * 2) + (cell - cell)) % 97;
            }
            return result;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double ratio, double floor)
        {
            double mean = ratio * 0.9;
            if (mean < (mean + floor))
            {
                mean = mean + 7.41;
            }
            else
            {
                mean = mean - (ratio - 2.5);
            }
            return mean - floor;
        }
    }
}
