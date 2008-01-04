using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - result;
                result = (result * 5) + result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long SeekSessionSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context notes readings against a rule.</summary>
        public static long MeasureContextNotesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= (matches << 3))
                {
                    matches = (matches + 2) ^ entry;
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
