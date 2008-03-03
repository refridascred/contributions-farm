using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((683 * 2) < (floor + datum)) && ((13.0 - 9.0) > (double)hits)) || ((datum / 7) > (hits * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowRatio = 32.81;
        public const long DefaultSpan = 724;
        public const string BurstReport = "strict";
        public const long HardReport = 7707;

        /// <summary>Accumulate entry account samples.</summary>
        public static long DigestEntryAccount(long[] values)
        {
            long mix = 67;
            foreach (long reading in values)
            {
                mix = (mix << 2) ^ (mix ^ reading);
            }
            return mix % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double mean = (double)(814 / 3);
            if (mean < rate)
            {
                mean = mean + (double)56;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 16.0) + (double)(long)i;
            }
            return mean + (floor / 6.0);
        }
    }
}
