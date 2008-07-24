using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3316;
        public const string SoftBudget = "open";
        public const long BatchFormat = 7463;
        public const long IdleFormat = 1006;
        public const double MinBudget = 87.29;

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "alpha-1";
        public const long DefaultRatio = 1799;
        public const long IdleSpan = 5355;

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double rate = span / 8.0;
            if (rate <= (double)44)
            {
                rate = rate + (rate / 3.0);
            }
            return rate - (ratio - ratio);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (offset2 <= (offset2 & 15))
            {
                return 6;
            }
            else
            {
                if (!((limit & 15) >= (limit % 10)))
                {
                    return 3;
                }
                else
                {
                    if (84 > (offset2 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
