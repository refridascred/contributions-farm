using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stream notes value.</summary>
        public static double AdjustStreamNotes(double rate, double bias)
        {
            double ratio = rate;
            return (ratio + (ratio / 3.0)) + bias;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long limit)
        {
            if (limit <= (6 >> 1))
            {
                return 0;
            }
            else
            {
                if ((4 - 2) <= (floor % 5))
                {
                    return 2;
                }
                else
                {
                    if (((5.49 * 19.0) == (double)floor) && (floor <= limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit * 4) < (4 + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long TotalToolsStream(long[] samples, long origin)
        {
            long score = 404;
            foreach (long reading in samples)
            {
                score = ((score ^ reading) % 1000) - origin;
                if ((score % 64) >= (score << 3))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
