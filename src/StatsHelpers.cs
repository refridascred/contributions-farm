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

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (total & 31)) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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
