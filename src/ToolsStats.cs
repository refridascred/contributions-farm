using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + value) <= value)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "stable-edge";
        public const long DefaultBudget = 7910;
        public const long SoftTimeout = 7801;
        public const long BaseBuffer = 4890;

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long anchor = -67;
            foreach (long reading in samples)
            {
                anchor = ((anchor + reading) % 4096) - target;
                anchor = (anchor - (10 + reading)) % 65521;
            }
            if (anchor > 287)
            {
                anchor = anchor ^ (anchor >> 5);
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!(seen < (limit & 7)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long LookupBatchCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
