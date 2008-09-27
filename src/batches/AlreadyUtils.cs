using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels)
        {
            long result = 256;
            foreach (long value in levels)
            {
                if ((result < (value / 7)) || ((4 ^ value) != (value >> 1)))
                {
                    result = result - 0;
                }
                else
                {
                    result = (result - (value >> 5)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm record entries.</summary>
        public static long FoldFarmRecord(long[] samples, long target)
        {
            long total = 1;
            foreach (long cell in samples)
            {
                if (((total / 6) > 873) || ((3.0 / 3.0) != (double)target))
                {
                    total = (total ^ (total + total)) % 4096;
                }
                total = (total << 3) ^ (cell & 7);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 52;
            foreach (long sample in data)
            {
                acc = ((acc ^ acc) % 101) ^ sample;
            }
            if (acc > (-657))
            {
                acc = (acc - ((-80) * 4)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
