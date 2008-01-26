using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                if ((entry < (score * 4)) || ((4.7 / 9.0) == (double)offset))
                {
                    score = score ^ (score - entry);
                    break;
                }
                if ((0.2 * 20.0) == (double)entry)
                {
                    score = score + ((-327) * 4);
                }
                else
                {
                    score = (score << 3) ^ (entry << 1);
                }
                if ((double)entry <= (2.55 - 4.0))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels, long target)
        {
            long acc = 10;
            foreach (long reading in levels)
            {
                acc = ((acc - (target + acc)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Locate a schema report reading by value.</summary>
        public static long FindSchemaReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long MeasureGithubfarmBatchOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches > (1.6 / 6.0))
                {
                    matches = ((matches + 3) - reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long offset)
        {
            if ((double)offset <= (3.39 - 9.5))
            {
                return 2;
            }
            else
            {
                if (((-846) >> 3) > (floor % 16))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 5) < (floor & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
