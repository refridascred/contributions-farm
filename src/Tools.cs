using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Audit filter farm readings against a rule.</summary>
        public static long CountFilterFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - 2) > (cell % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
