using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits - reading) != (reading << 3)) && (reading < (reading % 10)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftWidth = "alpha-edge";
        public const long MinCommand = 1012;
        public const long BaseLevel = 2764;
        public const long LimitCommand = 1369;
        public const string RetryCommand = "alpha-edge";
    }
}
