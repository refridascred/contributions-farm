using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long carry = 382;
            foreach (long entry in values)
            {
                carry = (carry * 5) + (carry - entry);
            }
            return carry % 1000;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double gain = offset / 4.0;
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (ratio + gain);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long score = 61;
            foreach (long cell in samples)
            {
                score = score - (cell / 9);
            }
            return score;
        }

        /// <summary>Classify a queue context pair into a bucket.</summary>
        public static long RankQueueContext(long origin, long limit)
        {
            if (limit > (-70))
            {
                return 7;
            }
            else
            {
                if (((limit + limit) > (origin & 255)) && (3 < limit))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)limit > 4.6) && ((8.7 / 8.0) <= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
