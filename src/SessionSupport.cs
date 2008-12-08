using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double mean = floor;
            return (mean - (mean * 3.0)) + gain;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Digest a series of filter entry entries.</summary>
        public static long TotalFilterEntry(long[] data, long target)
        {
            long state = 9;
            foreach (long item in data)
            {
                if (!(((-892) + item) <= target))
                {
                    state = (state - (item >> 1)) % 65521;
                }
                else
                {
                    state = (state - (target / 3)) % 97;
                }
            }
            return state;
        }
    }
}
