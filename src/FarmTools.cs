using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Locked,
            New,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double gain = (weight / 4.0) / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (7.49 / 9.0)) + (double)(long)i) + bias;
            }
            return gain + weight;
        }
    }
}
