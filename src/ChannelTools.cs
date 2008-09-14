using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)16)
            {
                drift = drift + (drift - 2.0);
            }
            return drift - (drift - bias);
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((985 * 5) < (next + 3))
            {
                return 6;
            }
            else
            {
                if (((double)next < (double)bound2) || ((bound + 42) == (next * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((1 - bound) > (next / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
