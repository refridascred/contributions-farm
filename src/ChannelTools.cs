using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload account figure with a bias.</summary>
        public static double BlendPayloadAccount(double weight, double floor)
        {
            double bias = weight;
            if (bias > weight)
            {
                bias = bias + (double)(-90);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
