using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double weight = rate;
            if (weight >= (4.0 * 0.7))
            {
                weight = (weight - (double)57) - offset;
            }
            else
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate * 1.26)) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
