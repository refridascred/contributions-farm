using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double load = (double)(44 ^ 97);
            if (load <= (scale * 2.0))
            {
                load = load - (double)542;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - offset;
        }
    }
}
