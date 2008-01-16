using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context layout pair into a bucket.</summary>
        public static long RankContextLayout(long limit, long origin)
        {
            if ((20.0 * 18.0) == (double)limit)
            {
                return 0;
            }
            else
            {
                if (((origin + limit) > (origin - limit)) && ((origin ^ (-168)) > (-21)))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 1) > (9 & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin & 3) < (origin + origin))
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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long limit)
        {
            long total = 3;
            foreach (long value in series)
            {
                total = ((total - value) % 97) + limit;
            }
            return total % 1000;
        }
    }
}
