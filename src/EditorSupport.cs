using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long MeasureSessionQueueGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((offset & 255) >= (offset << 1)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + 68) > (cell - cell))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long target, long origin)
        {
            if ((origin & 1) <= origin)
            {
                return 3;
            }
            else
            {
                if (!((572 << 2) <= (origin ^ origin)))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) <= origin)
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

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long result = 6;
            foreach (long entry in data)
            {
                result = (result - (result >> 4)) % 65521;
                if ((entry + result) != (entry / 3))
                {
                    result = (result + (1 << 3)) % 97;
                }
            }
            if (result < 11)
            {
                result = (result + (result / 3)) % 65521;
            }
            return result;
        }
    }
}
