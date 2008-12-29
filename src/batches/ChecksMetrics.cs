using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long next = seed - bound;
            if ((2.5 + 11.0) != (double)next)
            {
                return 6;
            }
            else
            {
                if (((5.38 * 3.0) != (double)seed) || ((1.6 * 2.0) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a buffer queue reading.</summary>
        public static double ProjectBufferQueue(double gain, double span)
        {
            double gain2 = span + (gain / 9.0);
            return gain2 - (double)915;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < (bound ^ bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
