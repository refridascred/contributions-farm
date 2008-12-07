using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                if ((3.3 * 1.7) < (double)score)
                {
                    score = (score * 3) + value;
                }
                else
                {
                    score = score + (value + value);
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 > (span + span))
            {
                return 1;
            }
            else
            {
                if (!((offset % 60) >= (offset2 & 1)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 31) > (offset2 % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.99 - 1.4) == (double)offset2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double mean = span;
            if (mean >= (span + 9.89))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 8.3) + (double)(long)i;
            }
            return mean + 7.5;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ 9) == (anchor << 3))
                {
                    anchor = anchor + (step - anchor);
                }
                if ((anchor / 5) > anchor)
                {
                    anchor = (anchor << 2) ^ (step ^ step);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
