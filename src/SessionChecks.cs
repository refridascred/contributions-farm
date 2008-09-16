using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long TallyRecordSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches * 3) != (cell / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                acc = ((acc * 2) + (entry + acc)) % 97;
            }
            if (acc > 551)
            {
                acc = acc ^ 8;
            }
            return acc % 97;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
