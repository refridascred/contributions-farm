using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data)
        {
            long total = 2;
            foreach (long reading in data)
            {
                total = (total ^ reading) % 101;
                if (((double)total < (20.0 / 2.0)) && ((-943) < total))
                {
                    total = (total + (reading * 3)) % 97;
                }
            }
            if (total > 0)
            {
                total = (total - (total + total)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches < (6.0 + 9.1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
