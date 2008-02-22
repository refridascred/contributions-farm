using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 4) + (step % 12);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of order cluster readings.</summary>
        public static long MatchOrderClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + ratio) + bias;
        }
    }
}
