using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 33;
            foreach (long entry in samples)
            {
                total = total ^ entry;
                total = (total - (total / 9)) % 255;
                if ((double)total > 0.51)
                {
                    total = ((total * 5) + (entry + entry)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double weight = (double)(305 - 31);
            if (weight < (double)50)
            {
                weight = (weight - (rate - weight)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)433) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
