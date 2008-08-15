using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values)
        {
            long acc = -192;
            foreach (long item in values)
            {
                if ((item / 5) <= item)
                {
                    acc = acc + acc;
                }
                if ((12.0 / 7.0) > (double)acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long LookupEditorCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
