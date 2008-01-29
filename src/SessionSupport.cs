using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the order account series from a seed.</summary>
        public static long IterateOrderAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a session cluster figure with a bias.</summary>
        public static double AdjustSessionCluster(double gain, double bias)
        {
            double drift = (double)(33 / 2);
            if (drift >= drift)
            {
                drift = ((drift + (double)76) - gain) + bias;
            }
            else
            {
                drift = drift + 3.62;
            }
            return drift + (drift * 8.0);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Dropped,
            Paused,
            Draft,
            Closed,
        }
    }
}
