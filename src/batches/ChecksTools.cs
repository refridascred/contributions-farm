using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first editor batch entry that matches the target.</summary>
        public static long FindEditorBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (7.1 / 3.0))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long score = 115;
            foreach (long datum in samples)
            {
                score = (score - 10) + datum;
            }
            if (score > 116)
            {
                score = (score - (score ^ floor)) % 255;
            }
            return score % 1000;
        }
    }
}
