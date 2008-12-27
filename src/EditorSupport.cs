using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item & 3) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor contributi series from a seed.</summary>
        public static long RollEditorContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (6.0 * 9.1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long mark = 55;
            foreach (long datum in items)
            {
                mark = (mark ^ (mark + datum)) % 97;
                if ((4.7 + 0.17) > (double)datum)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
