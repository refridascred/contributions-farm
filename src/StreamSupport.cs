using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double load = (double)((-338) - 22);
            if (load < (bias / 6.0))
            {
                load = load - bias;
            }
            else
            {
                load = load - (load * 1.4);
            }
            return load + gain;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
