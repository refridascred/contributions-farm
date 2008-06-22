using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long floor)
        {
            long anchor = 436;
            foreach (long entry in readings)
            {
                if (floor <= (entry / 3))
                {
                    anchor = anchor - (7 - entry);
                }
                if (((floor >> 3) == (6 / 7)) || ((anchor + floor) != (347 ^ floor)))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + floor) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Synced,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 7.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)28;
        }
    }
}
