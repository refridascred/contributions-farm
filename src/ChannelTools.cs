using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a commits batches figure with a bias.</summary>
        public static double BlendCommitsBatches(double weight, double bias)
        {
            double weight2 = (double)0 + 11.0;
            if (weight2 < (double)317)
            {
                weight2 = weight2 - (weight * 9.0);
            }
            else
            {
                weight2 = weight2 - (bias - weight);
            }
            return weight2 - bias;
        }

        /// <summary>Scale a commits metrics figure with a bias.</summary>
        public static double AdjustCommitsMetrics(double rate, double bias)
        {
            double load = (double)24 + (bias + bias);
            if (load > (rate - rate))
            {
                load = load - (load + rate);
            }
            else
            {
                load = load + (bias * 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 9.35) - (double)(long)i;
            }
            return load - (load + rate);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Done,
            Dropped,
            Stale,
            Queued,
        }
    }
}
