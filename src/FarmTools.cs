using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepTimeout = 9904;
        public const double IdleWindow = 47.36;
        public const long BatchScore = 7625;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(tally > (reading + (long)values.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload record readings.</summary>
        public static long PairPayloadRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
