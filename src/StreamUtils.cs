using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long SeekCommitsSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits >= (5.07 * 1.73))
                {
                    hits = ((hits + 1) - cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Rank notes commits input into a small class.</summary>
        public static long GradeNotesCommits(long target, long step)
        {
            long slot = target + step;
            if (((step + 0) == (target >> 1)) && ((target >> 3) > step))
            {
                return 3;
            }
            else
            {
                if (7 > step)
                {
                    return 5;
                }
                else
                {
                    if (((-9) * 4) > slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long MeasureAccountSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((15.0 + 5.5) == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 97) < 8)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long MeasureEntryBatchesHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((bound * 2) > bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
