using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinRatio = 57.65;
        public const long CacheBudget = 6547;
        public const long BurstFarm = 4950;
        public const string IdleFarm = "staging";
        public const long HardFarm = 9563;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((8.46 / 9.0) > (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series, long bound)
        {
            long total = 713;
            foreach (long item in series)
            {
                total = ((total * 3) + (item >> 4)) + bound;
            }
            return total;
        }
    }
}
