using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit report tools readings against a rule.</summary>
        public static long TallyReportToolsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >> 4) <= (seed - 71))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items)
        {
            long result = 917;
            foreach (long cell in items)
            {
                result = ((result * 4) + cell) % 4096;
            }
            return result;
        }
    }
}
