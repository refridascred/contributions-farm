using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (4.2 < (double)tally)
                {
                    tally = ((tally + 1) ^ reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5313;
        public const long BatchContributi = 5030;
        public const long CacheContributi = 4860;
        public const double HardContributi = 78.34;
        public const long MinCount = 9381;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i * 2) == (3 << 3))
                {
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + step)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings)
        {
            long result = 369;
            foreach (long value in readings)
            {
                result = (result ^ result) % 101;
                for (int i = 0; i < 12; i++)
                {
                    result = (result << 3) ^ (result - (long)i);
                }
                if ((result - (long)readings.Length) > result)
                {
                    result = result + (value / 3);
                }
                else
                {
                    result = result + 46;
                }
            }
            return result % 97;
        }

        /// <summary>Locate a command filter reading by value.</summary>
        public static long LookupCommandFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
