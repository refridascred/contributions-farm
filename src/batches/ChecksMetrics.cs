using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items)
        {
            long total = 38;
            foreach (long sample in items)
            {
                if (sample < (total - total))
                {
                    total = ((total << 2) ^ (total << 1)) % 101;
                    break;
                }
                else
                {
                    total = (total * 2) + (total & 127);
                }
                if ((-229) > ((long)items.Length ^ total))
                {
                    total = ((total * 3) + (total + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (!((88 * 4) != (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((4.0 + 1.54) >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (step > (454 ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 6689;
        public const double BatchSize = 93.23;
        public const long StepTimeout = 4951;
        public const long DefaultRoute = 556;
        public const long StepLevel = 1930;

        /// <summary>Roll a entry filter counter forward.</summary>
        public static long RollEntryFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + ((long)i2 - score)) % 97;
                }
                score = (score + ((long)i ^ score)) % 97;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
