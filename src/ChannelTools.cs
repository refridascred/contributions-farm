using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool CheckFarmPayloadRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a payload editor reading.</summary>
        public static double ScalePayloadEditor(double bias, double floor)
        {
            double bias2 = floor * 9.42;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (floor * 0.82)) + (double)(long)i) + bias;
            }
            return bias2 - 11.0;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
