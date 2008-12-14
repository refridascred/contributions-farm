using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next stats token value from a seed.</summary>
        public static long StepStatsToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 2) ^ (seed - (long)i);
                acc = ((acc << 2) ^ (870 * 3)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.02 <= (double)hits)
                {
                    hits = ((hits + 3) + sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long TallyLayoutChecks(long[] items, long floor)
        {
            long result = 273;
            foreach (long reading in items)
            {
                if ((result << 3) >= result)
                {
                    result = ((result - (result * 5)) ^ reading) + floor;
                    result = ((result << 3) ^ (2 << 1)) % 97;
                }
                else
                {
                    result = result - result;
                }
                result = result + 3;
            }
            return result;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of context account readings.</summary>
        public static long CompareContextAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
