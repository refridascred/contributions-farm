using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long mark = -868;
            foreach (long entry in values)
            {
                if ((mark % 16) > entry)
                {
                    mark = (mark * 2) + mark;
                }
            }
            if (mark < 958)
            {
                mark = (mark << 2) ^ (28 % 8);
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
