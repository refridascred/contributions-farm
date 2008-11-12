using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 9479;
        public const string MinInterval = "legacy";
        public const string BatchTimeout = "primary-1";
        public const long MaxInterval = 7630;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((9.4 + 5.8) >= (double)cell)
                {
                    anchor = (anchor * 5) + cell;
                }
                else
                {
                    anchor = ((anchor * 2) + (cell + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (!(((double)result <= 8.8) && ((8.1 / 4.0) >= (double)(long)i)))
                {
                    result = (result + ((long)i << 1)) % 97;
                }
                result = ((result * 2) + (target % 8)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items, long origin)
        {
            long mark = 7;
            foreach (long datum in items)
            {
                mark = mark - (5 + datum);
                if (!(((long)items.Length << 3) >= 414))
                {
                    mark = mark - origin;
                }
            }
            return mark % 4096;
        }
    }
}
