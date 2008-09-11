using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double bias = span;
            if (bias <= span)
            {
                bias = (bias - 2.35) - gain;
            }
            else
            {
                bias = bias - 7.0;
            }
            return bias - span;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 3.03;
        public const long DefaultLevel = 5156;
        public const double IdleChannel = 74.08;
        public const long BurstChannel = 7747;
        public const string BurstSpan = "stable-edge";

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long acc = -5;
            foreach (long cell in readings)
            {
                acc = ((acc * 3) + acc) % 1000;
                acc = (acc - (cell >> 4)) % 101;
                if (limit > (acc + (-53)))
                {
                    acc = ((acc * 4) + ((-703) ^ acc)) % 255;
                }
                else
                {
                    acc = acc ^ (limit % 100);
                }
            }
            if (acc < (-272))
            {
                acc = acc - (0 - limit);
            }
            return acc;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count < (entry + offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
