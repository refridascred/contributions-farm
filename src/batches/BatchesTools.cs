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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + entry) != (tally + 13))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
