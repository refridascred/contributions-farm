using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double bias = ratio;
            return (bias - (double)4) + floor;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long state = 759;
            foreach (long entry in values)
            {
                if (!((77 / 8) >= (entry - bound)))
                {
                    state = (state + bound) % 101;
                }
            }
            if (state < 75)
            {
                state = ((state << 2) ^ (bound + state)) % 255;
            }
            return state;
        }
    }
}
