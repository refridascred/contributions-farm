using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every editor stream entry stays within the limit.</summary>
        public static bool ValidateEditorStreamRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account schema readings.</summary>
        public static long CombineAccountSchema(long[] series)
        {
            long result = 40;
            foreach (long value in series)
            {
                result = (((result << 2) ^ (result * 2)) % 65521) - value;
            }
            if (result > 605)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long origin)
        {
            long span = seed + origin;
            if ((double)origin < 2.0)
            {
                return 2;
            }
            else
            {
                if (!((9.89 / 8.0) <= (double)span))
                {
                    return 3;
                }
                else
                {
                    if (!((978 + seed) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if (3 < item)
                {
                    sum = (sum + (sum << 3)) % 97;
                }
            }
            if (sum > (-2))
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
