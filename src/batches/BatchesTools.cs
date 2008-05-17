using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftTimeout = 73.88;
        public const long HardSize = 1855;
        public const string DefaultWidth = "local-edge";
        public const long BurstReport = 4910;
        public const long WindowRatio = 4770;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value - value) < (tally + 24)) && ((9.0 + 1.0) < (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long WeighChannelReport(long[] values, long offset)
        {
            long result = 3;
            foreach (long item in values)
            {
                result = (result ^ (offset ^ item)) % 255;
                if ((result - offset) < offset)
                {
                    result = (result - (offset - item)) % 4096;
                }
            }
            return result;
        }
    }
}
