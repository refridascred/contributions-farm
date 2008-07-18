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

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long MatchClusterRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + ((-996) >> 5)) % 101;
                mark = mark + (mark / 4);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
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
