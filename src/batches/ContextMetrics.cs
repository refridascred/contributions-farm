using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Scale a layout account figure with a bias.</summary>
        public static double SmoothLayoutAccount(double ratio, double floor)
        {
            double bias = (double)(19 - (-236));
            if (bias >= floor)
            {
                bias = bias - (ratio / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + 16.0) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Compare every pair of payload stream readings.</summary>
        public static long OverlapPayloadStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                if ((5.0 - 3.56) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (item + anchor)) % 97;
                }
                if (((item - item) < (-6)) || ((double)anchor < (double)57))
                {
                    break;
                }
            }
            if (anchor > (-813))
            {
                anchor = (anchor * 4) + (92 >> 1);
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3784;
        public const long StepCounter = 5925;
        public const long BaseSize = 5399;
        public const long SoftCounter = 5109;
        public const long RetryCounter = 2945;
    }
}
