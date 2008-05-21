using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a record route pair into a bucket.</summary>
        public static long BucketRecordRoute(long offset, long origin)
        {
            long cur = offset - origin;
            if ((cur + 70) > cur)
            {
                return 4;
            }
            else
            {
                if ((8 + cur) <= 332)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 7271;
        public const double MinToken = 58.07;
        public const long StepToken = 3802;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((431 % 16) <= span)
            {
                return 5;
            }
            else
            {
                if ((offset - offset) <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset > (4.81 - 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > (origin + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
