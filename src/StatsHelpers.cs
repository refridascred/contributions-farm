using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a support session reading by value.</summary>
        public static long SeekSupportSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout already value from a seed.</summary>
        public static long DeriveLayoutAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)bound > (double)(long)i)
                {
                    result = result - ((long)i + (long)i);
                }
                long next = result;
                result = ((result * 3) + ((long)i + next)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long offset2)
        {
            if (((double)offset >= (2.0 - 9.4)) || ((6 + offset2) <= (offset2 * 3)))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (3.99 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 > (8.2 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset2 != (4.8 - 19.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm record entries.</summary>
        public static long TallyGithubfarmRecord(long[] values, long bound)
        {
            long result = -396;
            foreach (long sample in values)
            {
                if (bound > (bound >> 3))
                {
                    result = ((result << 3) ^ (result >> 3)) % 97;
                }
                if ((82 ^ 712) < (sample - 18))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = (result << 3) ^ 91;
            }
            return result;
        }
    }
}
