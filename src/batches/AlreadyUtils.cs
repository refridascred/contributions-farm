using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two command channel measurements.</summary>
        public static double SmoothCommandChannel(double scale, double span)
        {
            double scale2 = span;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 - span) - (double)(long)i) + scale;
            }
            return scale2 + (double)92;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long bound)
        {
            if ((target ^ target) <= (target + target))
            {
                return 2;
            }
            else
            {
                if ((bound % 97) >= (bound >> 5))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
