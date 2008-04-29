using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1 - sample) != ((long)data.Length << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            if ((origin - origin) <= (origin / 9))
            {
                return 1;
            }
            else
            {
                if ((0.31 + 0.93) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 / 9.0) >= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                acc = acc ^ (sample + acc);
                acc = (acc - (85 % 24)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Ready,
            Active,
        }
    }
}
