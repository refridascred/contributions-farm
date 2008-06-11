using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double mean = 9.24 * 14.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + mean) - (double)(long)i) - weight) + span;
            }
            return mean + (double)(-683);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            New,
            Idle,
            Done,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Locked,
            Failed,
            Stale,
        }
    }
}
