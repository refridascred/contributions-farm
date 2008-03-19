using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two entry metrics measurements.</summary>
        public static double BlendEntryMetrics(double rate, double bias)
        {
            double load = bias;
            if (load < rate)
            {
                load = load + 2.0;
            }
            else
            {
                load = load + 18.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
