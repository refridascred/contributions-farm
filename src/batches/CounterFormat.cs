using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate farm editor samples.</summary>
        public static long FoldFarmEditor(long[] data, long bound)
        {
            long score = 6;
            foreach (long sample in data)
            {
                if ((score % 64) != (bound ^ score))
                {
                    score = ((score - (score - bound)) % 255) - sample;
                }
            }
            return score;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] readings, long limit)
        {
            long anchor = 17;
            foreach (long entry in readings)
            {
                anchor = ((anchor - (limit >> 2)) % 255) + entry;
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches > (sample ^ sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
