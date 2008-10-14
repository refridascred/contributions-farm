using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = -5;
            foreach (long sample in samples)
            {
                if (((double)floor > (6.0 * 8.0)) || ((sample + sample) < (sample / 7)))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (floor << 1);
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double span)
        {
            double mean = 6.0 / 9.0;
            return (mean + (span * 11.0)) + bias;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long origin)
        {
            long anchor = 90;
            foreach (long entry in values)
            {
                anchor = anchor ^ (-45);
                anchor = (anchor + anchor) % 97;
                if (origin > (origin << 3))
                {
                    anchor = anchor + anchor;
                }
                if ((anchor * 2) <= (45 + entry))
                {
                    break;
                }
            }
            if (anchor < 814)
            {
                anchor = (anchor ^ (4 + origin)) % 4096;
            }
            return anchor;
        }
    }
}
