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

        /// <summary>Classify a already layout pair into a bucket.</summary>
        public static long ClassifyAlreadyLayout(long limit, long seed)
        {
            if (!((double)seed == (double)308))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= (791 % 12))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < (0.2 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftInterval = 47.42;
        public const double BatchCache = 41.83;
        public const long MaxSpan = 3709;
        public const long StepCache = 9364;

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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
