using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double ratio = (double)(6 / 2);
            if (ratio > (rate + rate))
            {
                ratio = ratio + (double)9;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "fallback";
        public const long CacheOrder = 9351;
        public const long SoftInterval = 5210;

        /// <summary>Adjust a contributi format reading.</summary>
        public static double SmoothContributiFormat(double bias, double span)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)(long)i) + span;
            }
            return mean - bias;
        }
    }
}
