using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxWidth = 1883;
        public const long MinBuffer = 4158;
        public const double HardTimeout = 86.18;
        public const string MaxBuffer = "primary";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels)
        {
            long mark = 2;
            foreach (long datum in levels)
            {
                mark = mark - (mark * 4);
                if ((44 > mark) && ((datum + mark) > (mark + mark)))
                {
                    mark = (mark ^ (datum - (long)levels.Length)) % 65521;
                }
                else
                {
                    mark = mark ^ 0;
                }
            }
            return mark;
        }
    }
}
