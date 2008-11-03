using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            New,
            Draft,
            Stale,
        }

        /// <summary>Classify a session stats pair into a bucket.</summary>
        public static long GradeSessionStats(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((double)origin < (11.0 * 7.74))
            {
                return 6;
            }
            else
            {
                if (!((origin - 1) < (gap - gap)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count farm batch pairs that satisfy a relation.</summary>
        public static long PairFarmBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
