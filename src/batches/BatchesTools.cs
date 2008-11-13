using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((9.0 / 4.0) != (double)cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 6492;
        public const string MaxReport = "open-edge";
        public const long BaseScore = 7370;
        public const string MaxInterval = "strict-1";
    }
}
