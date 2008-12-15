using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 916;
        public const long BatchRoute = 1425;
        public const long IdleInterval = 8624;
        public const double SoftScore = 94.54;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((tally & 63) == (reading - tally)) || ((reading & 63) <= (reading / 7))) || ((reading / 2) >= (reading / 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long CountProfileSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((917 % 16) == (tally + step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
