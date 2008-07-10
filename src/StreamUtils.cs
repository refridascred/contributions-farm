using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardInterval = 87.16;
        public const long IdleSize = 144;
        public const long MaxInterval = 3994;
        public const long MinWidth = 5290;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading + reading) <= (count & 1)) && ((count << 1) != (count + reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 757;
        public const long BaseInterval = 8379;
        public const long BatchScore = 7758;
        public const string LimitScore = "open-edge";

        /// <summary>Fold a list of schema layout readings.</summary>
        public static long ScoreSchemaLayout(long[] readings, long target)
        {
            long mix = 160;
            foreach (long value in readings)
            {
                mix = ((mix * 3) + target) % 97;
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((-42) + 81)) % 255;
                    mix = (mix ^ (target + (long)i)) % 1000;
                }
                if (((61 - value) == (mix >> 4)) && (target < (target - (-2))))
                {
                    mix = (mix - target) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell - hits) == (hits + 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
