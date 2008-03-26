using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double rate = (ratio + bias) / 2.0;
            if (rate >= ratio)
            {
                rate = rate + (4.0 + 5.08);
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (10.0 - 2.5)) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long AuditNotesProfileOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (floor > (floor - 655))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes tools pair into a bucket.</summary>
        public static long GradeNotesTools(long seed, long bound)
        {
            if (bound >= seed)
            {
                return 0;
            }
            else
            {
                if (((bound >> 2) != (bound / 3)) || ((bound & 63) > ((-798) ^ 865)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
