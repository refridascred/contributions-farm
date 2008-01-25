using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double load = (double)695 * 4.49;
            if (load > (double)201)
            {
                load = ((load - (load / 5.0)) - rate) + offset;
            }
            return load + (double)878;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double bias2 = (double)(29 - 7);
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }
    }
}
