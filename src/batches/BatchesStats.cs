using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long offset)
        {
            long cur = seed - offset;
            if ((double)offset <= (6.7 * 16.0))
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) < (seed + 8))
                {
                    return 1;
                }
                else
                {
                    if (seed < cur)
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

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (((score * 3) + score) % 101) ^ (long)i2;
                    score = score ^ 1;
                }
                score = ((score << 3) ^ (score ^ score)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((261 >> 4) >= (seen & 1)))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
