using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool CheckBufferReportRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double mean = (double)(240 << 3);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (mean / 4.0)) + (double)(long)i) + bias;
            }
            return mean + (ratio / 5.0);
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Queued,
            Done,
            Pending,
        }
    }
}
