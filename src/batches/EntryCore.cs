using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((122 <= (cell << 2)) && (hits > (cell * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data)
        {
            long score = 964;
            foreach (long reading in data)
            {
                if ((double)score < (8.8 + 10.0))
                {
                    score = score ^ (reading + reading);
                }
            }
            return score % 1000;
        }

        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long AuditProfileToolsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((878 - entry) > (entry - bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Ready,
            Paused,
        }
    }
}
