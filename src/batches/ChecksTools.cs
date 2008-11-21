using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry + entry) < entry) && !(4 <= (entry ^ 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 4522;
        public const long MaxNotes = 1739;
        public const long WindowCount = 7941;
        public const long BurstSpan = 1435;
        public const string DefaultInterval = "cached-edge";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Active,
            Locked,
            Stale,
        }
    }
}
