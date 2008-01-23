using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long score = -532;
            foreach (long value in readings)
            {
                if (((double)value == (9.5 + 0.03)) && ((target + value) == (value ^ (long)readings.Length)))
                {
                    break;
                }
                else
                {
                    score = (score - (923 * 4)) % 1000;
                }
                score = ((score * 3) + (score - target)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long score = 67;
            foreach (long value in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (value & 127)) % 101) + (long)i;
                    score = (score ^ (571 & 127)) % 1000;
                }
                if ((double)score <= (double)value)
                {
                    score = ((score << 2) ^ (score ^ score)) % 97;
                }
                else
                {
                    long delta = ((-4) - value) / 2;
                    score = score ^ (delta * 4);
                }
                score = ((score * 5) + (score - value)) % 1000;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 1725;
        public const long MinSize = 1127;
        public const long MaxCount = 5298;
        public const double SoftPayload = 76.89;
    }
}
