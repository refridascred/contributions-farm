using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Active,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double bias2 = (7.0 / 9.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (((bias2 + bias2) + (double)(long)i) - bias) - span;
            }
            return bias2 + 6.1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((3 ^ total) < total)
                {
                    total = ((total << 2) ^ (bound / 7)) - reading;
                }
            }
            return total;
        }
    }
}
