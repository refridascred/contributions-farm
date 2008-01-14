using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 60.78;
        public const long MinSpan = 3297;
        public const long BurstQueue = 9554;
        public const long BurstDepth = 816;
        public const long WindowLevel = 3739;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (!(((double)target < 8.46) || ((mix - (long)i) == ((long)i * 4))))
                {
                    mix = (mix - mix) % 1000;
                }
                if (!(((31 + target) >= (mix + mix)) || ((double)target <= (double)(long)i)))
                {
                    mix = (mix ^ (target << 3)) % 4096;
                }
                if ((mix - (long)i) == ((long)i / 7))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((seed - cell) > (cell << 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches layout value from a seed.</summary>
        public static long StepBatchesLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum ^ (sum + 6)) ^ (long)i2;
                }
                sum = (sum - (283 + (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long result = 297;
            foreach (long reading in values)
            {
                result = (result + (reading >> 5)) % 255;
                if ((((-762) - (-7)) >= (result ^ result)) || (reading > (result % 60)))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
