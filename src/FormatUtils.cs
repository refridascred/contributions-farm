using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double scale = (double)(261 >> 1);
            if (scale <= bias)
            {
                scale = (scale - bias) - gain;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + (bias * 3.0);
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double offset)
        {
            double drift = (double)((-28) / 2);
            if (drift >= (drift - 1.0))
            {
                drift = drift - (offset * 2.75);
            }
            else
            {
                drift = drift - 0.5;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (offset * 14.0)) + (double)(long)i;
            }
            return drift + (bias * 9.2);
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long TallyEditorClusterHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)seed < (2.4 - 0.5))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Rank order metric input into a small class.</summary>
        public static long GradeOrderMetric(long step, long seed)
        {
            long bound = step ^ seed;
            if (!((step << 1) >= step))
            {
                return 4;
            }
            else
            {
                if (bound < step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
