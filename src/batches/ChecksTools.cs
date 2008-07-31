using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double mean = (gain - gain) * 9.88;
            if (mean <= (floor + 6.0))
            {
                mean = mean - mean;
            }
            return mean - 8.0;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples, long seed)
        {
            long anchor = 13;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor << 3) ^ ((long)i % 8)) - seed;
                }
                if (!((0 << 1) <= (entry << 1)))
                {
                    anchor = (anchor ^ (anchor % 2)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
