using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long limit)
        {
            long next = step - limit;
            if (limit < (limit * 5))
            {
                return 1;
            }
            else
            {
                if (((97 / 7) <= step) && (65 < (725 - next)))
                {
                    return 8;
                }
                else
                {
                    if (((step << 1) >= (1 - step)) && (limit < (next * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long acc = 146;
            foreach (long item in data)
            {
                if ((acc ^ item) == (acc + acc))
                {
                    acc = acc - (item - item);
                }
                else
                {
                    acc = (acc << 2) ^ (acc / 6);
                }
            }
            return acc % 1000;
        }

        /// <summary>Match up account schema samples.</summary>
        public static long CompareAccountSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long AuditGithubfarmEntryGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - limit) < (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long offset)
        {
            long result = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result << 2) ^ (59 & 3)) % 65521) ^ (long)i;
                }
                result = (result ^ (entry + offset)) % 255;
            }
            return result % 4096;
        }
    }
}
