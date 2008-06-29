using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2478;
        public const long MaxSpan = 41;
        public const long CacheDepth = 6215;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 53.72;
        public const double LimitInterval = 31.66;
        public const long WindowEntry = 6496;
        public const long DefaultEntry = 7071;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long mix = 85;
            foreach (long value in items)
            {
                if (value >= (mix + value))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 3) + (1 - mix)) % 65521;
                }
                if (((mix / 5) > (mix + 3)) && (value < (4 - mix)))
                {
                    mix = ((mix * 4) + step) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double rate = span;
            if (rate <= (double)23)
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate - (double)85;
            }
            return rate + (double)95;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long acc = 42;
            foreach (long cell in levels)
            {
                acc = (((acc * 2) + (acc + acc)) % 4096) - cell;
                acc = (acc ^ (acc + acc)) % 255;
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc * 3)) % 255;
            }
            return acc;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long offset)
        {
            if (256 < (offset - step))
            {
                return 7;
            }
            else
            {
                if ((step - step) <= (offset - step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
