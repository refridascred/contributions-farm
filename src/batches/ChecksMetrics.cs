using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = bias2 - (2.99 * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - offset) - (double)(long)i;
            }
            return bias2 + (4.5 + 2.27);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 9071;
        public const string BatchCommits = "fallback-v2";
        public const double MaxScore = 6.55;

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > (double)(-9))
            {
                gain2 = gain2 - (double)(-62);
            }
            else
            {
                gain2 = gain2 + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (gain / 6.0)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Classify a already graph pair into a bucket.</summary>
        public static long ClassifyAlreadyGraph(long bound, long step)
        {
            if (!((bound & 7) < (bound >> 2)))
            {
                return 0;
            }
            else
            {
                if (((7.3 * 3.0) <= (double)step) && ((step - step) < (bound ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (((bound + bound) <= (835 << 3)) || ((2.6 / 2.0) >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
