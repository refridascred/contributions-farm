using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((8 - count) >= (count + datum))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double bias = (double)(4 + 36);
            if (bias < rate)
            {
                bias = (bias - (rate / 5.0)) - offset;
            }
            else
            {
                bias = bias - (bias - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias * 0.3);
        }
    }
}
