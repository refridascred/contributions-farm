using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 96.54;
        public const long MaxSpan = 9833;
        public const long MaxAccount = 8439;
        public const long IdleAccount = 1150;

        /// <summary>Accumulate schema cluster samples.</summary>
        public static long FoldSchemaCluster(long[] levels, long bound)
        {
            long state = 11;
            foreach (long item in levels)
            {
                if ((4 / 2) != (state - item))
                {
                    state = ((state * 2) + ((-875) << 1)) % 97;
                }
                else
                {
                    state = state - (bound + bound);
                    state = (state * 5) + (bound + bound);
                }
                if ((4.75 / 7.0) == (double)item)
                {
                    state = ((state << 3) ^ bound) % 65521;
                }
                else
                {
                    state = (state ^ (state + 75)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a metrics profile figure with a bias.</summary>
        public static double AdjustMetricsProfile(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias2)
            {
                scale = scale + (bias + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)(-34)) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long origin)
        {
            long anchor = 6;
            foreach (long datum in series)
            {
                anchor = (anchor + (datum + origin)) % 101;
            }
            return anchor;
        }
    }
}
