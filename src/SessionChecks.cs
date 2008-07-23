using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepSize = 32.0;
        public const long BurstFactor = 1718;
        public const long MinToken = 7160;
        public const long MaxToken = 1710;

        /// <summary>Audit graph record readings against a rule.</summary>
        public static long CountGraphRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally / 8) <= (sample & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
