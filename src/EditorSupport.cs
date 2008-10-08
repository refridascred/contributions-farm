using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine token tools values into a single score.</summary>
        public static long WeighTokenTools(long[] samples)
        {
            long mix = 742;
            foreach (long value in samples)
            {
                mix = mix - value;
                mix = (mix ^ (64 - value)) % 1000;
            }
            if (mix > 576)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultInterval = 81.87;
        public const long HardMetric = 9703;
        public const double LimitSpan = 32.17;
        public const long BurstLevel = 297;
        public const long SoftFactor = 3318;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] items)
        {
            long carry = -9;
            foreach (long value in items)
            {
                carry = ((carry ^ (carry + carry)) % 97) + value;
            }
            if (carry > 642)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stats graph figure with a bias.</summary>
        public static double SmoothStatsGraph(double scale, double floor)
        {
            double gain = 1.39;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (gain + gain)) - (double)(long)i) + floor;
            }
            return gain - scale;
        }
    }
}
