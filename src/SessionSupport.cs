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

        /// <summary>Digest a series of format layout entries.</summary>
        public static long TallyFormatLayout(long[] data, long offset)
        {
            long total = 20;
            foreach (long sample in data)
            {
                if ((double)total > (5.43 / 2.0))
                {
                    total = (total ^ offset) - sample;
                }
            }
            return total;
        }
    }
}
