using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= (floor * 18.0))
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 + (weight + weight2);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (double)5) + (double)(long)i;
            }
            return weight2 + floor;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
