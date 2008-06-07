using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit already checks readings against a rule.</summary>
        public static long CountAlreadyChecksMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell / 5) > (origin + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Active,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long mark = 6;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + mark) + reading;
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
