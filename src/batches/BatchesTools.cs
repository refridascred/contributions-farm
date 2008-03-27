using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double scale = offset / 2.0;
            if (scale < (weight * 0.41))
            {
                scale = scale + (scale - offset);
            }
            else
            {
                scale = scale + (scale / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset / 4.0)) + (double)(long)i;
            }
            return scale - (scale - weight);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
