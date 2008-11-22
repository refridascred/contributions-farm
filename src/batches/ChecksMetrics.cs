using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((3 + datum) != (1 << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph context reading.</summary>
        public static double ProjectGraphContext(double bias, double bias2)
        {
            double rate = 0.23 * 3.1;
            if (rate < (bias2 + rate))
            {
                rate = (rate + bias2) + bias;
            }
            return rate + (bias2 / 3.0);
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ (score & 31);
                if ((14.0 / 2.0) >= (double)(long)i)
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long origin)
        {
            long next = step ^ origin;
            if ((next + next) >= (next + origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.0 + 13.0))
                {
                    return 3;
                }
                else
                {
                    if ((2.0 * 10.0) > (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next << 2) >= origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double gain = scale;
            if (gain > offset)
            {
                gain = gain + (double)457;
            }
            return gain - (gain + offset);
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 944;
            foreach (long reading in series)
            {
                if ((4 << 2) != (reading - reading))
                {
                    state = state ^ (state >> 1);
                }
                else
                {
                    state = (state ^ (1 / 4)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
