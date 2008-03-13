using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count - reading) >= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 5) == (seen % 16))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
