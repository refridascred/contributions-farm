using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long target)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((target + sum) < (target * 4))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ (322 + reading);
                }
            }
            return sum;
        }

        /// <summary>Match up schema contributi samples.</summary>
        public static long OverlapSchemaContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (13.0 - 19.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long limit, long step)
        {
            long next = limit + step;
            if (next > (48 % 12))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (15.0 + 11.0))
                {
                    return 4;
                }
                else
                {
                    if (next <= (limit + (-56)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((next + step) >= (limit ^ next)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token buffer measurements.</summary>
        public static double SmoothTokenBuffer(double weight, double bias)
        {
            double mean = weight;
            if (mean < 13.0)
            {
                mean = (mean - 13.0) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
