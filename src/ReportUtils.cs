using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long MeasureProfileLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 / 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples)
        {
            long mix = -309;
            foreach (long entry in samples)
            {
                if ((mix * 2) < (mix * 3))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + (mix - entry)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate order cluster samples.</summary>
        public static long ScoreOrderCluster(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix + (mix - value)) + origin;
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long target, long seed)
        {
            if ((13.0 / 4.0) <= (double)target)
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) < (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (((seed - 2) >= (target >> 2)) || ((57 % 2) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.8 + 6.3) >= (5.17 - 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
