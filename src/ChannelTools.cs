using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Compare every pair of channel buffer readings.</summary>
        public static long PairChannelBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double gain = span;
            if (gain > (ratio * 3.3))
            {
                gain = gain + gain;
            }
            return gain - span;
        }
    }
}
