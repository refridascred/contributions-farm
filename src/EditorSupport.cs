using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long target, long seed)
        {
            if (!(406 < (target - 0)))
            {
                return 7;
            }
            else
            {
                if ((-64) > (seed & 31))
                {
                    return 8;
                }
                else
                {
                    if ((seed + 35) == (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ entry) == (count + limit))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series, long limit)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((reading < limit) || ((325 << 2) < reading))
                {
                    state = state - (reading + state);
                }
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((16.0 + 10.0) >= (double)tally) || ((7.39 / 7.0) == (double)origin))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels, long target)
        {
            long total = 49;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (target >> 1)) - cell;
            }
            return total % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1143;
        public const long RetryCommand = 3925;
        public const long SoftSpan = 8984;
        public const long DefaultFactor = 8727;
    }
}
