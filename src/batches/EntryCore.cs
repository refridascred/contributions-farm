using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two command format measurements.</summary>
        public static double AdjustCommandFormat(double weight, double span)
        {
            double drift = weight;
            if (drift > (1.33 - 16.0))
            {
                drift = (drift + (double)502) + span;
            }
            return drift - (double)89;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double offset)
        {
            double scale = gain + (gain / 3.0);
            if (scale <= (gain + scale))
            {
                scale = scale + (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double gain = 4.5;
            if (gain <= (3.0 / 7.0))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain + (floor / 6.0);
            }
            return gain + (floor - gain);
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
