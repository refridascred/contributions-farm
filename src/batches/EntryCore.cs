using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next token layout value from a seed.</summary>
        public static long StepTokenLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (748 & 15)) % 255) ^ (long)i2;
                }
                score = (score - (floor + floor)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (1 > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample / 5) != (sample + hits)) || ((double)sample < (11.0 + 20.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
