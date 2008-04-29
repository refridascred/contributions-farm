using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long step)
        {
            long span = floor ^ step;
            if (span < (span / 4))
            {
                return 3;
            }
            else
            {
                if (((26 - floor) == (floor + floor)) && ((floor / 9) < step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double drift = (double)(898 & 127);
            if (drift >= (drift * 2.12))
            {
                drift = (drift - (4.83 - 6.0)) + bias;
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of command context entries.</summary>
        public static long ScoreCommandContext(long[] samples)
        {
            long anchor = 66;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor ^ (anchor - anchor)) % 97) - (long)i) + datum;
                }
                if (!(anchor >= (anchor << 3)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }
    }
}
