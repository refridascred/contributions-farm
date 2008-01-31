using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                long bound = ((-79) + (long)i) * 3;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    bound = (((bound * 3) + (bound >> 4)) % 255) ^ (long)i2;
                    sum = (sum ^ (bound / 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long CountProfileMetricHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema counter input into a small class.</summary>
        public static long BucketSchemaCounter(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset >> 4) != (origin - limit))
            {
                return 4;
            }
            else
            {
                if (limit <= (664 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Ready,
            Queued,
            Pending,
            Failed,
        }
    }
}
