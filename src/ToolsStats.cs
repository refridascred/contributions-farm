using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((112 + 400) < (count % 5))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2856;
        public const long SoftWidth = 7942;
        public const long RetryBatch = 8369;

        /// <summary>Find the first cache order entry that matches the target.</summary>
        public static long LookupCacheOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9817;
        public const string HardDepth = "cached-edge";
        public const long LimitSchema = 629;

        /// <summary>Fold a list of profile metric readings.</summary>
        public static long CombineProfileMetric(long[] readings, long limit)
        {
            long mix = 422;
            foreach (long cell in readings)
            {
                if (!((limit ^ 82) <= mix))
                {
                    mix = (((mix * 5) + (410 & 3)) % 65521) - cell;
                }
                else
                {
                    mix = mix ^ limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
