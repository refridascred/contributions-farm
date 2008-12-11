using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxDepth = 5094;
        public const long BaseToken = 40;
        public const double StepToken = 86.92;
        public const long RetryWidth = 6560;

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long CountTokenMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + (long)levels.Length) > 4)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score + (limit >> 1)) - (long)i2;
                    score = (score - (164 - 402)) % 4096;
                }
                score = ((score * 5) + (score + score)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item - hits) >= item) || ((offset << 2) >= hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
