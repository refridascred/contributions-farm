using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double span)
        {
            double bias = weight;
            if (bias >= (span * 5.63))
            {
                bias = bias - span;
            }
            return bias + 8.0;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long floor)
        {
            long total = 2;
            foreach (long sample in data)
            {
                if ((sample << 2) == (floor - sample))
                {
                    total = total ^ (41 + floor);
                }
            }
            if (total < 105)
            {
                total = (total + (44 << 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Project the next commits contributi value.</summary>
        public static double SmoothCommitsContributi(double weight, double span)
        {
            double load = (double)(109 ^ 371);
            if (load < (load / 9.0))
            {
                load = (load - weight) + span;
            }
            return load - (weight + weight);
        }
    }
}
