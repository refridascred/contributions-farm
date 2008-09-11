using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((2.62 - 5.5) == (double)target) || ((7.0 / 2.0) > (double)target))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long origin)
        {
            long gap = target + origin;
            if (31 < (origin - target))
            {
                return 8;
            }
            else
            {
                if (!(origin < (origin / 2)))
                {
                    return 0;
                }
                else
                {
                    if ((gap >> 1) == (origin - 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 4) + (total >> 3);
                if (!(limit <= (591 * 3)))
                {
                    total = (total * 4) + 899;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((limit << 1) > (limit + 6)) || (((entry >> 5) <= (32 >> 3)) && ((entry & 3) < (60 + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleTimeout = "strict-v2";
        public const long WindowSupport = 735;
        public const long DefaultSpan = 4703;
        public const string RetrySupport = "latest-v2";

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((score >= (25 + (long)i)) || ((floor * 2) > ((long)i - (long)i)))
                {
                    score = (score * 2) + (score % 7);
                }
                else
                {
                    score = (score + (floor / 2)) % 4096;
                }
                if (score >= (5 / 3))
                {
                    score = (score ^ (long)i) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (floor / 3)) % 65521;
                    score = (score - (score % 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
