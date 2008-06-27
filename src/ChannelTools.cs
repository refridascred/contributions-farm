using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstWidth = "latest";
        public const long IdleDepth = 5249;
        public const long WindowFactor = 568;

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double BlendCommandFarm(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio * 3.55))
            {
                ratio = (ratio - bias) + rate;
            }
            else
            {
                ratio = ratio + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.56 / 5.0)) + (double)(long)i;
            }
            return ratio + (double)15;
        }
    }
}
