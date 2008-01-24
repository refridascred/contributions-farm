using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long CombineGraphContributi(long[] samples)
        {
            long mark = 20;
            foreach (long entry in samples)
            {
                mark = (mark ^ (mark / 2)) - entry;
            }
            if (mark > 770)
            {
                mark = ((mark << 2) ^ ((-9) + 700)) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 8509;
        public const long SoftSize = 7306;
        public const double HardRatio = 95.09;

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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
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
    }
}
