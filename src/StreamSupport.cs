using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (floor / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain - gain2);
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Done,
            Failed,
            Draft,
            Active,
        }
    }
}
