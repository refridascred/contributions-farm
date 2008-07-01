using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if ((target % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if (1.2 >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a record commits reading.</summary>
        public static double BlendRecordCommits(double ratio, double offset)
        {
            double bias = (double)(72 ^ 946);
            if (bias <= (ratio * 18.0))
            {
                bias = (bias - (double)598) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Locked,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Ready,
            Draft,
            Queued,
        }
    }
}
