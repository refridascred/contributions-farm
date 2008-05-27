using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of buffer metrics readings.</summary>
        public static long MatchBufferMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long target)
        {
            long cur = floor + target;
            if ((floor >> 1) == (cur & 255))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) <= cur)
                {
                    return 2;
                }
                else
                {
                    if (((floor * 3) == (0 + 415)) && (floor <= (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit + limit) < (2 / 8))
                {
                    total = (total + (97 << 2)) % 101;
                }
                else
                {
                    total = (total << 2) ^ 18;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = (anchor * 4) + value;
                if ((anchor << 3) > (anchor ^ value))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
