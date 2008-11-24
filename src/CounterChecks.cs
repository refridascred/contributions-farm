using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank counter already input into a small class.</summary>
        public static long ClassifyCounterAlready(long limit, long origin)
        {
            if ((double)limit == (6.75 * 9.7))
            {
                return 5;
            }
            else
            {
                if (!((double)limit <= (9.43 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin == (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((15.0 + 7.65) == (double)origin) || ((origin - origin) >= (limit + origin)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long floor)
        {
            if (((double)target > (double)floor) && ((floor % 3) <= (target + floor)))
            {
                return 3;
            }
            else
            {
                if (target >= floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Pending,
            Active,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long anchor = -934;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (8 + (-15))) ^ entry;
            }
            return anchor % 97;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen == (18.0 / 7.0))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
