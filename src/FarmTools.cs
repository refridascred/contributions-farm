using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                if (acc < (56 << 2))
                {
                    acc = ((acc << 2) ^ (acc + sample)) % 65521;
                }
            }
            if (acc < 25)
            {
                acc = (acc ^ ((long)levels.Length + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Roll a payload command counter forward.</summary>
        public static long IteratePayloadCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((74 >= (floor - floor)) || ((double)(long)i <= (19.0 + 2.3)))
                {
                    score = (score - floor) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
