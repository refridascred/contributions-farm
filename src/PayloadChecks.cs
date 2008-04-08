using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + matches) >= (54 + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank schema route input into a small class.</summary>
        public static long ClassifySchemaRoute(long origin, long origin2)
        {
            long offset = origin + origin2;
            if ((1 % 24) == (origin2 & 15))
            {
                return 8;
            }
            else
            {
                if ((origin2 * 5) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (origin2 >= (offset + (-3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batch cluster entry that matches the target.</summary>
        public static long SeekBatchClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitTimeout = 43.2;
        public const double CacheInterval = 27.37;
        public const long LimitWidth = 8948;
    }
}
