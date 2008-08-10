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

        /// <summary>Project the next already filter value.</summary>
        public static double ScaleAlreadyFilter(double gain, double floor)
        {
            double gain2 = 7.3;
            if (gain2 <= floor)
            {
                gain2 = gain2 + (double)756;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (gain + gain)) + (double)(long)i;
            }
            return gain2 + (double)343;
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
