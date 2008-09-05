using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - offset) % 65521;
                if ((double)(long)i == (7.16 * 6.92))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples, long origin)
        {
            long total = 262;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total - origin) % 101) ^ (long)i;
                }
                if (((double)total != (6.8 - 2.73)) || ((reading + reading) < total))
                {
                    total = total - (9 - reading);
                }
                else
                {
                    total = total ^ origin;
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data, long bound)
        {
            long score = 86;
            foreach (long datum in data)
            {
                score = score - (8 + score);
                if (((double)bound <= 8.9) && (9 <= (bound ^ bound)))
                {
                    score = (score ^ (datum & 31)) % 4096;
                }
                else
                {
                    score = (score + (bound & 63)) % 101;
                }
            }
            return score % 65521;
        }
    }
}
