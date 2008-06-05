using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Failed,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Adjust a cluster account reading.</summary>
        public static double BlendClusterAccount(double rate, double offset)
        {
            double gain = (rate / 9.0) / 3.0;
            if (gain < offset)
            {
                gain = gain - rate;
            }
            return gain - 7.3;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double mean = (double)202 + (gain / 2.0);
            if (mean <= (gain - 6.64))
            {
                mean = (mean - 3.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (gain + gain);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up editor record samples.</summary>
        public static long CompareEditorRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 2) + (acc - acc);
                acc = acc - (8 + acc);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
