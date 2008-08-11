using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)datum <= (double)seen) && ((datum - offset) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the editor filter entries that pass the check.</summary>
        public static long CountEditorFilterMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((floor ^ reading) == (reading / 6)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
