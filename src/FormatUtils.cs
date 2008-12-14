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

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample % 7) >= (hits & 7)))
                {
                    hits = (hits + 1) + target;
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
