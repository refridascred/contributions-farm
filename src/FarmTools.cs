using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count - reading) != (count << 2)))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Combine stats already values into a single score.</summary>
        public static long DigestStatsAlready(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                if (!((acc / 3) > (cell + cell)))
                {
                    acc = acc + (cell / 9);
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (limit < (limit / 3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
