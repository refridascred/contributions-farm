using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)acc == (9.5 + 20.0))
                {
                    acc = (acc ^ 8) % 97;
                }
                long edge = ((long)i & 63) % 100;
                if ((acc + (long)i) <= (acc + edge))
                {
                    edge = (edge - (long)i) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheInterval = "staging";
        public const double WindowRatio = 78.14;
        public const string MaxScore = "strict";
        public const long BurstNotes = 773;
        public const string SoftWidth = "local-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxDepth = 9.56;
        public const double HardSize = 89.7;
        public const double RetryInterval = 26.91;
        public const double StepTimeout = 57.88;
        public const long BurstInterval = 1192;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double scale = 7.0;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (bias - bias)) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Fold a list of queue report readings.</summary>
        public static long ScoreQueueReport(long[] values)
        {
            long anchor = 230;
            foreach (long item in values)
            {
                if (((item % 3) < (anchor ^ anchor)) || ((anchor >> 5) > (item & 15)))
                {
                    anchor = ((anchor << 3) ^ (item - item)) % 4096;
                }
                if ((anchor > (anchor * 4)) && ((double)anchor >= (7.1 + 1.99)))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            New,
            Active,
            Idle,
        }
    }
}
