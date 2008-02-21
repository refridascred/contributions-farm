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

        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long IterateRecordGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - total;
                if (2 < (total - total))
                {
                    total = (total - (origin << 1)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the metric checks entries that pass the check.</summary>
        public static long MeasureMetricChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count / 2) < 2)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
