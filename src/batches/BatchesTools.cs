using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (reading * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "open";
        public const double MinToken = 65.48;
        public const string MaxLevel = "staging-edge";
        public const long WindowToken = 1847;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches - matches) <= (sample + sample)) || ((6 * 5) >= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
