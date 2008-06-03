using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series, long step)
        {
            long mix = 500;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix - step)) % 101) - value;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items)
        {
            long mix = -18;
            foreach (long datum in items)
            {
                if (!((datum + datum) >= (94 - datum)))
                {
                    mix = (mix + (40 ^ datum)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of format token entries.</summary>
        public static long TallyFormatToken(long[] samples, long offset)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = ((acc - (datum % 2)) % 4096) + offset;
            }
            return acc % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftRatio = 292;
        public const double BurstContributi = 94.68;
        public const long StepContributi = 8802;
        public const string StepWidth = "standard";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long step)
        {
            if ((step + origin) <= (step - 72))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
