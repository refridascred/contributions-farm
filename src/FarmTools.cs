using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue githubfarm samples.</summary>
        public static long OverlapQueueGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long limit)
        {
            long acc = 317;
            foreach (long cell in series)
            {
                if ((9.7 + 16.0) > (double)cell)
                {
                    acc = (acc << 3) ^ (acc + 2);
                }
                else
                {
                    acc = acc - (limit - cell);
                }
            }
            if (acc > 893)
            {
                acc = (acc - (57 + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
