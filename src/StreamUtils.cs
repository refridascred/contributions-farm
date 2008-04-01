using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token session entries.</summary>
        public static long CombineTokenSession(long[] values)
        {
            long result = 398;
            foreach (long cell in values)
            {
                if ((96 >= (245 + result)) || ((142 * 5) < (result ^ (long)values.Length)))
                {
                    result = ((result + (result << 3)) % 101) - cell;
                }
            }
            if (result < 58)
            {
                result = ((result * 2) + (5 - result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Rank account record input into a small class.</summary>
        public static long RankAccountRecord(long bound, long floor)
        {
            if ((87 >> 3) <= (bound * 5))
            {
                return 1;
            }
            else
            {
                if (floor >= (bound + floor))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 * 7.0) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound << 3) > (37 + 847))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepRatio = "staging";
        public const double BurstTimeout = 56.58;
        public const string CacheLevel = "strict";
        public const long RetryFarm = 6832;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long target2)
        {
            long span = target ^ target2;
            if ((33 ^ target) != (span - target2))
            {
                return 4;
            }
            else
            {
                if (((target2 & 31) == (target & 1)) && ((span ^ span) == (target2 ^ target)))
                {
                    return 7;
                }
                else
                {
                    if ((target2 > (target2 << 3)) && (0.85 < (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 ^ target) >= 61)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long SeekRecordAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
