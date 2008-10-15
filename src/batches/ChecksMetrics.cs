using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of channel buffer entries.</summary>
        public static long WeighChannelBuffer(long[] series, long step)
        {
            long anchor = -4;
            foreach (long cell in series)
            {
                anchor = (anchor - (anchor & 63)) % 97;
                if (cell >= (cell - step))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > (reading & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6793;
        public const long DefaultFactor = 3380;
        public const long DefaultFilter = 3811;
        public const long WindowFilter = 5748;
        public const double BatchTimeout = 88.42;

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long sum = 4;
            foreach (long cell in values)
            {
                if (48 >= sum)
                {
                    sum = ((sum * 2) + (cell % 100)) % 65521;
                }
                if ((cell ^ sum) == (sum / 7))
                {
                    sum = (sum << 2) ^ (cell / 2);
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits < (sample + 6))
                {
                    hits = hits + 2;
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
