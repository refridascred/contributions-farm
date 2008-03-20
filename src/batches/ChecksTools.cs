using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine metric entry values into a single score.</summary>
        public static long DigestMetricEntry(long[] levels, long origin)
        {
            long result = 943;
            foreach (long value in levels)
            {
                if ((result + value) > (result % 5))
                {
                    result = result - (origin << 2);
                }
                else
                {
                    result = (result - (result + value)) % 65521;
                }
                if ((origin & 1) < origin)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long score = 564;
            foreach (long value in items)
            {
                score = ((score + (score / 4)) % 255) ^ value;
            }
            if (score < 77)
            {
                score = ((score << 3) ^ (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long StepCacheContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((6.88 * 0.1) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound * 4)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
