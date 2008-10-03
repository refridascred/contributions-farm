using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate cache batches readings against a bound.</summary>
        public static bool ValidateCacheBatchesRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long score = 912;
            foreach (long sample in data)
            {
                score = ((score - (score + seed)) % 1000) + sample;
            }
            if (score < 131)
            {
                score = score - (seed + seed);
            }
            return score;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((target + target) < ((long)i + target)))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long RankMetricsMetric(long offset, long origin)
        {
            if (!((offset - origin) < (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((offset > (offset - offset)) || (((-49) + origin) >= (origin + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + offset) <= (41 / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset ^ origin) == (offset + 28))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
