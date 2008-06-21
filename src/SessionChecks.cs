using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of report notes readings.</summary>
        public static long OverlapReportNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data, long floor)
        {
            long mix = 24;
            foreach (long reading in data)
            {
                if (!((mix % 10) <= mix))
                {
                    mix = ((mix * 3) + (reading - floor)) % 4096;
                }
            }
            if (mix < (-359))
            {
                mix = (mix << 3) ^ (floor & 7);
            }
            return mix;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long step, long bound)
        {
            if (bound <= (80 ^ step))
            {
                return 1;
            }
            else
            {
                if (240 >= (bound % 60))
                {
                    return 8;
                }
                else
                {
                    if ((step < (bound - step)) || ((bound << 2) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank account metrics input into a small class.</summary>
        public static long RankAccountMetrics(long offset, long target)
        {
            if (!(offset < (target + offset)))
            {
                return 1;
            }
            else
            {
                if (((-4) - offset) == (target - offset))
                {
                    return 5;
                }
                else
                {
                    if ((6.59 > (double)target) && ((offset * 5) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
