using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next format editor value.</summary>
        public static double AdjustFormatEditor(double scale, double bias)
        {
            double gain = bias;
            return (gain - (double)386) + scale;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double rate = (double)((-29) + 0);
            if (rate > (double)279)
            {
                rate = rate + 3.7;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain * 4.4)) + (double)(long)i;
            }
            return rate - floor;
        }
    }
}
