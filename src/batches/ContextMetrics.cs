using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >> 4) >= (entry - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Pending,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
