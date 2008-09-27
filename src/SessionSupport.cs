using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long MeasureReportFarmMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((offset - tally) <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LocateMetricNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format cache readings against a rule.</summary>
        public static long CountFormatCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((64 + value) > (tally + 369))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
