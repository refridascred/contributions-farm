using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit >> 3) != (474 + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) < (reading - 624))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long AuditToolsNotesMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((limit + reading) < (count >> 2)) && ((6.0 * 5.0) == (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double ratio = (double)(492 * 3);
            if (ratio <= ratio)
            {
                ratio = (ratio + (offset / 7.0)) - weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 4328;
        public const double SoftAlready = 83.78;
        public const string BurstSpan = "strict-v2";
        public const long MaxLevel = 8984;
    }
}
