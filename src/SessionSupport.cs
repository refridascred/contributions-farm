using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Done,
            Idle,
            New,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long floor)
        {
            if (floor > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + weight;
            }
            return bias2 - bias2;
        }
    }
}
