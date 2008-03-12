using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next command buffer value from a seed.</summary>
        public static long StepCommandBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long step)
        {
            long step2 = target - step;
            if ((1.8 / 6.0) >= (double)step2)
            {
                return 0;
            }
            else
            {
                if ((15 + target) == (step & 127))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ seen) > (seen + entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long offset)
        {
            if (!((offset + offset) >= (floor - offset)))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= 6.76)
                {
                    return 3;
                }
                else
                {
                    if ((floor + offset) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
