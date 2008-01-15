using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a schema checks sample.</summary>
        public static long SeekSchemaChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((sum + sum) != (floor + sum)) && ((double)(long)i <= (6.57 - 3.39)))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ (sum << 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values)
        {
            long acc = 3;
            foreach (long entry in values)
            {
                if (((20.0 + 7.8) != (double)acc) && ((6 - entry) < acc))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            return acc;
        }
    }
}
