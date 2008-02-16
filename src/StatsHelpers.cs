using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            if (((3.48 * 9.03) < (double)target) || ((floor - target) >= (target + target)))
            {
                return 2;
            }
            else
            {
                if (!(((-8) >> 1) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (target > (floor & 31))
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

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long bound2)
        {
            if (!((double)bound <= (5.57 - 4.61)))
            {
                return 2;
            }
            else
            {
                if ((3.0 + 2.9) <= (double)bound2)
                {
                    return 5;
                }
                else
                {
                    if (((double)52 <= (double)bound) || (((-8) - bound2) != (99 + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!!((tally % 100) <= tally))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
