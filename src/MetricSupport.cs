using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 60) >= (matches * 3))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Rank command editor input into a small class.</summary>
        public static long ClassifyCommandEditor(long origin, long step)
        {
            if ((155 - 96) > (step + step))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (18.0 - 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((origin & 3) < (57 - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - step) == (step + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 7874;
        public const double IdleScore = 77.0;
        public const string CacheWidth = "standard-v2";
        public const long BurstStream = 6061;
        public const string WindowStream = "standard-edge";
    }
}
