using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count profile counter pairs that satisfy a relation.</summary>
        public static long PairProfileCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item > (item * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel batches measurements.</summary>
        public static double AdjustChannelBatches(double rate, double bias)
        {
            double ratio = (double)(232 >> 4);
            if (ratio >= ratio)
            {
                ratio = (ratio + (double)782) - rate;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryWidth = 8002;
        public const string DefaultAlready = "staging-edge";
        public const long SoftScore = 6457;
        public const long HardAlready = 5349;
        public const long CacheLevel = 4570;
    }
}
