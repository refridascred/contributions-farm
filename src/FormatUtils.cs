using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long AuditProfileGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - tally) != (sample << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long CountFilterAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count ^ count) > count) || (count > (cell / 8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                if ((568 ^ carry) > ((long)readings.Length >> 5))
                {
                    carry = carry + (67 % 97);
                    continue;
                }
                else
                {
                    carry = (carry ^ (cell + bound)) % 97;
                    carry = carry + bound;
                }
                if ((double)bound == (15.0 / 8.0))
                {
                    carry = (carry * 5) + bound;
                }
                else
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long TallyClusterBatchOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(offset < (-6)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long seed)
        {
            if (!((double)511 != (double)seed))
            {
                return 3;
            }
            else
            {
                if ((4.33 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) == (target - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + target) >= (target * 2)) || ((double)seed == (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache record samples.</summary>
        public static long CompareCacheRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
