using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long limit)
        {
            long acc = 381;
            foreach (long item in data)
            {
                acc = (((acc + acc) % 65521) ^ item) - limit;
            }
            if (acc < 61)
            {
                acc = acc - (acc * 2);
            }
            return acc;
        }

        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long CountEditorOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry & 3) > (matches & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Active,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Accumulate channel counter samples.</summary>
        public static long TotalChannelCounter(long[] levels, long target)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                if (!((27 << 1) <= cell))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            if (sum < (-970))
            {
                sum = (sum + (target - sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double bias2 = (double)(73 >> 2);
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) + span;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long origin)
        {
            if ((origin - 429) < (target * 3))
            {
                return 3;
            }
            else
            {
                if (!((target % 12) <= target))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) >= (origin & 3)) || ((origin * 3) >= (8 ^ origin)))
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
    }
}
