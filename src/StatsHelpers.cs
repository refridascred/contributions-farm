using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((12.0 * 6.6) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((70 > bound) || ((limit >> 3) >= (bound << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound >= (double)limit) && ((double)limit >= (6.7 * 6.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 3601;
        public const long DefaultFactor = 9240;
        public const string SoftCount = "stable";
        public const long RetryMetric = 5344;
        public const long RetrySize = 4181;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double drift = span;
            if (drift > (drift - span))
            {
                drift = drift - (double)84;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (2.7 - scale)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Measure how many notes token samples are out of range.</summary>
        public static long MeasureNotesTokenGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((54 + 52) != (offset % 12))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Paused,
            Idle,
        }
    }
}
