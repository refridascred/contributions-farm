using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long RankFarmReport(long offset, long target)
        {
            if (((3 ^ 5) > (offset % 16)) && ((3.86 + 1.0) < (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target - target) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double gain = (double)(72 % 64);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - 0.4) + (double)(long)i) + ratio) + span;
            }
            return gain - (double)939;
        }
    }
}
