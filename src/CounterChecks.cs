using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 5) > (cell << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long CountNotesProfileMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((limit + tally) >= (-127)) && ((tally ^ 8) <= tally))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long origin)
        {
            if ((2.7 / 6.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > 1.08)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long CountToolsEditorOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2.0 * 3.52) > (double)bound)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
