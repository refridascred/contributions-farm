using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long AuditSessionGithubfarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((15.0 + 3.2) <= (double)tally) || !((5.3 - 9.5) >= (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
