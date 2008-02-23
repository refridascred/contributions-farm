using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "staging-edge";
        public const double StepRatio = 51.62;
        public const long LimitSupport = 4234;
        public const long WindowSupport = 2028;

        /// <summary>Rank metrics window input into a small class.</summary>
        public static long ClassifyMetricsWindow(long offset, long limit)
        {
            if ((limit & 127) >= 6)
            {
                return 2;
            }
            else
            {
                if ((6.0 / 9.0) < (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long step, long origin)
        {
            long delta = step ^ origin;
            if (((double)step == (1.0 + 6.74)) || ((origin / 2) <= (step % 2)))
            {
                return 8;
            }
            else
            {
                if ((delta >> 1) < (step << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series)
        {
            long anchor = 47;
            foreach (long sample in series)
            {
                if ((anchor % 2) <= (sample + (long)series.Length))
                {
                    anchor = anchor + (1 + (long)series.Length);
                }
            }
            if (anchor < 29)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) % 101;
            }
            return anchor % 97;
        }
    }
}
