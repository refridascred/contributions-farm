using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if (((cell + acc) >= (acc << 2)) && ((cell ^ acc) == (acc + acc)))
                {
                    acc = (acc ^ cell) % 4096;
                }
                else
                {
                    acc = acc - (acc & 3);
                }
                if ((acc + acc) <= (acc & 15))
                {
                    acc = ((acc * 4) + (acc << 2)) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc << 3) ^ acc) % 4096;
            }
            return acc % 4096;
        }
    }
}
