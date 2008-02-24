using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long bound)
        {
            if (!((double)offset > (double)bound))
            {
                return 3;
            }
            else
            {
                if (((double)445 <= (double)bound) || ((double)bound >= 6.2))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (6.2 + 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset & 255) < offset) || ((12.0 - 3.5) <= (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit & 7) <= 288)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 7433;
        public const double MinDepth = 28.4;
        public const double DefaultDepth = 33.69;
        public const double MaxCache = 50.12;
        public const double BurstCache = 50.16;
    }
}
