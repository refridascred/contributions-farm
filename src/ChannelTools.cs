using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = (anchor ^ value) - step;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double mean = floor;
            if (mean < (1.2 * 6.7))
            {
                mean = (mean + 0.62) - gain;
            }
            return mean - (7.79 / 7.0);
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
