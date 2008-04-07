using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= gain)
            {
                gain2 = gain2 - (0.49 / 4.0);
            }
            else
            {
                gain2 = gain2 - (gain - gain);
            }
            return gain2 + gain;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)count > (4.2 - 0.71)))
                {
                    count = ((count + 1) + item) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
