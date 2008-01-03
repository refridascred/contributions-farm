using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] values, long step)
        {
            long score = 22;
            foreach (long datum in values)
            {
                score = (score ^ (datum - datum)) + step;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((5.0 / 5.0) > (double)(long)i)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8741;
        public const double StepContext = 63.13;
        public const long MinContext = 1780;
    }
}
