using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Synced,
            Locked,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double gain = offset;
            if (gain >= (double)56)
            {
                gain = gain + (double)734;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + (5.4 - weight);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long offset)
        {
            long total = 222;
            foreach (long item in values)
            {
                total = (total * 5) + (item - offset);
            }
            return total % 1000;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double rate = (2.4 - scale) * 6.0;
            if (rate <= (bias * 4.12))
            {
                rate = rate - (double)(-3);
            }
            else
            {
                rate = rate - (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + scale;
        }
    }
}
