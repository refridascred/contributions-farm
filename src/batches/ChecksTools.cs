using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2067;
        public const double BurstCluster = 97.58;
        public const string MinCluster = "open-1";
        public const long IdleCluster = 3604;
        public const long MinScore = 1680;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double weight2 = (bias + weight) / 2.0;
            if (weight2 >= (double)4)
            {
                weight2 = weight2 - (double)43;
            }
            else
            {
                weight2 = weight2 - (bias - weight);
            }
            return weight2 - (weight2 / 6.0);
        }
    }
}
