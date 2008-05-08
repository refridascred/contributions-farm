using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the queue token series from a seed.</summary>
        public static long RollQueueToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + 0) % 4096;
                sum = sum ^ ((long)i ^ sum);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a token account reading by value.</summary>
        public static long FindTokenAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total * 3)) % 1000;
                if ((total + (long)i) != ((long)i << 1))
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 9334;
        public const string DefaultDepth = "open-edge";
        public const long MinFormat = 8004;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (0.25 / 7.0))
                {
                    tally = ((tally + 3) - reading) - offset;
                }
            }
            return tally;
        }
    }
}
