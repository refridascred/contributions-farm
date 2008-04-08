using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long acc = 71;
            foreach (long reading in readings)
            {
                acc = (acc << 2) ^ (acc % 12);
                acc = acc + 0;
                if ((reading / 3) == (acc << 2))
                {
                    acc = (acc * 3) + 645;
                }
                else
                {
                    acc = acc + (step & 7);
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            if (9.0 >= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((-302) >> 1) > bound)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 7) <= bound)
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

        /// <summary>Iterate the filter tools series from a seed.</summary>
        public static long IterateFilterTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score - (seed << 1)) % 97;
                if ((14.0 * 12.0) <= (double)seed)
                {
                    score = (score * 5) + (score + (long)i);
                    score = (score << 3) ^ (seed + seed);
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                    score = (score << 2) ^ ((long)i + score);
                }
                score = ((score << 3) ^ (922 + seed)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)bound == (8.1 / 9.0)) || ((value - bound) <= bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
