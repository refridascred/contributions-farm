using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a githubfarm schema counter forward.</summary>
        public static long DeriveGithubfarmSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((154 ^ (-370)) <= (long)i))
                {
                    acc = (acc ^ ((-41) - acc)) % 1000;
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 2) <= (matches << 1))
                {
                    matches = ((matches + 1) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long floor)
        {
            long acc = 855;
            foreach (long sample in samples)
            {
                if ((785 - 242) > (floor + 1))
                {
                    acc = (((acc << 3) ^ (acc & 15)) % 4096) ^ sample;
                }
            }
            if (acc > 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }
    }
}
