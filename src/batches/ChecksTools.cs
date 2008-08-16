using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5104;
        public const string HardInterval = "local-v2";
        public const long SoftLevel = 3858;
        public const long CacheBudget = 9549;

        /// <summary>Project the next token queue value.</summary>
        public static double ProjectTokenQueue(double rate, double span)
        {
            double gain = rate * 9.72;
            if (gain >= gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (rate / 3.0);
            }
            return gain - (gain + rate);
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long IterateChecksEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                long offset = (518 - limit) + (limit - mark);
                mark = ((mark * 2) + (offset % 12)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
