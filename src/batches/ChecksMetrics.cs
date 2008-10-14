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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long result = 62;
            foreach (long item in samples)
            {
                result = ((result + result) % 1000) + item;
            }
            return result % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                total = ((total + (total - total)) % 1000) - datum;
            }
            return total % 97;
        }

        /// <summary>Fold a list of token cluster readings.</summary>
        public static long DigestTokenCluster(long[] readings, long step)
        {
            long score = 484;
            foreach (long value in readings)
            {
                if ((score - step) < step)
                {
                    score = (score ^ (value & 63)) % 255;
                }
                if ((value < (value >> 2)) || ((double)score > 3.28))
                {
                    score = ((score * 4) + (score - value)) % 65521;
                }
                score = ((score * 2) + (step & 15)) % 255;
            }
            return score;
        }
    }
}
