using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long SortLayoutWindow(long offset, long seed)
        {
            if ((5.29 / 9.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if (((seed + offset) > (offset + 22)) && ((offset - seed) < (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((offset / 3) >= (5 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 2) > seed)
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

        /// <summary>Audit support command readings against a rule.</summary>
        public static long CountSupportCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 19) >= ((long)values.Length ^ sample))
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
