using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double weight = bias;
            if (weight >= 7.9)
            {
                weight = weight + (weight / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long MeasureStreamMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) < (39 * 3))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long bound)
        {
            long diff = seed - bound;
            if (((9.0 - 8.7) <= (double)seed) && ((diff >> 5) < (diff + bound)))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) != (diff + diff))
                {
                    return 5;
                }
                else
                {
                    if (bound < seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed >= (4 ^ bound)) || ((seed - 97) < (bound * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
