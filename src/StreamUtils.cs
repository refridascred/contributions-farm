using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Locked,
            Synced,
            New,
            Pending,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long mix = 27;
            foreach (long value in levels)
            {
                if (((value + 5) == (value << 1)) && ((value + 556) >= value))
                {
                    mix = (mix << 3) ^ (value - 14);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Idle,
            Stale,
            New,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen > (352 + item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double gain = (ratio + ratio) / 6.0;
            if (gain >= ratio)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (double)6;
            }
            return gain - 6.57;
        }
    }
}
