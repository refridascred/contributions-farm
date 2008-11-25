using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of record tools readings.</summary>
        public static long PairRecordToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long seed, long target)
        {
            long span = seed - target;
            if (!((seed / 4) != (target + span)))
            {
                return 8;
            }
            else
            {
                if ((double)span != (8.3 / 3.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((target * 3) > target)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (double)78)
                {
                    return 3;
                }
                else
                {
                    if ((target + 0) < (82 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((15.0 * 3.5) < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
