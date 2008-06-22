using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long anchor = 85;
            foreach (long cell in data)
            {
                anchor = ((anchor * 5) + ((long)data.Length - step)) + cell;
            }
            if (anchor > 331)
            {
                anchor = (anchor * 2) + (anchor % 24);
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item << 1) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics account values into a single score.</summary>
        public static long ScoreMetricsAccount(long[] levels)
        {
            long result = -950;
            foreach (long cell in levels)
            {
                if ((4.69 > (double)result) || ((result ^ result) >= (cell ^ result)))
                {
                    result = result ^ (result ^ cell);
                }
                if ((0.73 + 0.7) >= (double)result)
                {
                    result = (result << 3) ^ (result % 10);
                }
                if (cell > (result * 4))
                {
                    result = ((result * 3) + (result << 1)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0 ^ count) > (sample + sample))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
