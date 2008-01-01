using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally + entry) >= 278) && (tally > (0 >> 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
