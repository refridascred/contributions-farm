using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double scale = (bias / 6.0) / 9.0;
            return (scale - 16.0) + floor;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = state - (32 + offset);
                state = (state - (offset + state)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
