using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits checks entries.</summary>
        public static long ScoreCommitsChecks(long[] readings, long floor)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = ((acc - ((long)readings.Length + floor)) % 255) + item;
            }
            return acc % 1000;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the command queue entries that pass the check.</summary>
        public static long TallyCommandQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell % 97) == (hits - 851))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
