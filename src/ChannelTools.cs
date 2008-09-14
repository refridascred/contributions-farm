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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
