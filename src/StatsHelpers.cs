using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit githubfarm record readings against a rule.</summary>
        public static long CountGithubfarmRecordMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + sample) < (bound & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long offset)
        {
            if (8 > (offset >> 4))
            {
                return 6;
            }
            else
            {
                if ((1.0 * 4.3) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (!((3.0 + 9.3) != (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long offset)
        {
            if (((double)offset > (7.1 + 4.5)) || (origin >= (38 >> 1)))
            {
                return 0;
            }
            else
            {
                if ((48 * 3) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) == (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = (gain + gain) - offset;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight * 10.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
