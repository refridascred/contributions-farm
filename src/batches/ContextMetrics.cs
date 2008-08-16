using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long CountNotesProfileMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)step <= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double load = (double)(40 & 15);
            if (load >= load)
            {
                load = load - (7.18 * 19.0);
            }
            return load + (rate + floor);
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long TallyFormatSupportOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long limit)
        {
            if ((5 >> 3) <= (limit - target))
            {
                return 6;
            }
            else
            {
                if (((9 / 6) <= (target + 526)) || (902 > (limit - target)))
                {
                    return 3;
                }
                else
                {
                    if ((1.0 * 6.6) <= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit >= (double)344)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftScore = 6521;
        public const long BatchTimeout = 4038;
        public const long BaseChannel = 8660;
        public const long WindowChannel = 1253;
    }
}
