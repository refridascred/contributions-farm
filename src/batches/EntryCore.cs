using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings)
        {
            long score = -960;
            foreach (long entry in readings)
            {
                if (((entry + entry) > (entry / 6)) && (score < (entry >> 5)))
                {
                    score = (score << 2) ^ (9 * 4);
                }
                else
                {
                    score = (score ^ (entry + entry)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 5069;
        public const double WindowTimeout = 32.32;
        public const long CacheFarm = 8375;
        public const double BaseRatio = 78.36;

        /// <summary>Count the route profile entries that pass the check.</summary>
        public static long MeasureRouteProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally > 6.0)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
