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

        /// <summary>Count payload already pairs that satisfy a relation.</summary>
        public static long MatchPayloadAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long floor)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                anchor = ((anchor << 2) ^ (cell + anchor)) + floor;
                anchor = (anchor << 2) ^ cell;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitTimeout = 43.2;
        public const double CacheInterval = 27.37;
        public const long LimitWidth = 8948;
    }
}
