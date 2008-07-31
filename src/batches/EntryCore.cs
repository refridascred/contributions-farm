using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 6281;
        public const string WindowLevel = "strict";
        public const long MinCount = 4329;
        public const long HardReport = 9880;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio / 5.0);
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (18.0 + span);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally >= cell) && ((6.13 / 6.0) < (double)tally)) && ((tally + 31) < 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Ready,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
