using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of support commits readings.</summary>
        public static long DigestSupportCommits(long[] readings, long target)
        {
            long score = 821;
            foreach (long cell in readings)
            {
                score = (score - (7 + target)) % 97;
                score = ((score * 3) + (cell << 2)) % 4096;
                if (score < target)
                {
                    score = ((score * 4) + (target + cell)) % 65521;
                }
                else
                {
                    score = (score + (cell >> 2)) % 255;
                }
            }
            if (score < 4)
            {
                score = (score - score) % 65521;
            }
            return score;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long limit)
        {
            long diff = origin + limit;
            if ((double)(-41) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((diff + limit) <= diff)
                {
                    return 1;
                }
                else
                {
                    if ((limit - 0) < (limit + diff))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 3) ^ total;
                if ((4.0 + 0.46) >= (double)total)
                {
                    total = total - 1;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first metrics buffer entry that matches the target.</summary>
        public static long LookupMetricsBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
